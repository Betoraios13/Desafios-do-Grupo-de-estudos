using System;
using System.Collections;
using scripts.Model.data;
using scripts.Model;
using scripts.View;
using scripts.Controller.controls;

namespace scripts.Controller.game
{
    public class Game
    {
        private List<Entity> entities = new();
        private List<Entity> entitiesCache = new();
        private Random random = new();
        private MyTimer timer = new();
        private int score;
        private int rounds;
        private int minutes;

        private void GetEntities()
        {
            var data = new DataEntity();
            data.Load();
            entities = data.entitiesLoaded;

            if (entities.Count > 0)
            {
                foreach (var entity in entitiesCache)
                {
                    if (entities.Contains(entity))
                    {
                        entities.Remove(entity);
                    }
                }
            }
        }

        private void CalculateScore()
        {
            minutes = timer.GetTime();
            score = 100 - ((rounds - 1) * 10) - minutes;
        }

        public void Start()
        {
            rounds = 1;
            GetEntities();

            var index = random.Next(0, entities.Count);
            var entity = entities[index];

            entitiesCache.Add(entity);

            GameView.NewGame(entity.category);

            ClickEnter.Press();

            InGame(entity);
        }

        public void InGame(Entity entity)
        {
            timer.Start();

            for (int i = 10; i > 0; i--)
            {
                var index = random.Next(0, entity.clues.Count);
                GameView.inGame(rounds, entity.clues[index]);
                entity.clues.Remove(entity.clues[index]);

                var input = Console.ReadLine() ?? "";

                if (!string.IsNullOrEmpty(input))
                {
                    if (input.ToLower() == entity.answer.ToLower())
                    {
                        //Venceu
                        timer.Stop();
                        CalculateScore();
                        GameView.Win(entity.answer, rounds, score);
                        Console.ReadLine();
                        return;
                    }

                    //Errou
                    GameView.Miss(rounds);
                    input = Console.ReadLine() ?? "";

                    if (input.ToLower() == "desistir")
                    {
                        GameView.GiveUp(entity.answer, score);

                        ClickEnter.Press();

                        return;
                    }
                }
                rounds++;
            }

            GameView.GameOver(entity.answer);
            
            ClickEnter.Press();
        }
    }
}
