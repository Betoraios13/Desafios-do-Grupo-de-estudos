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
        private int score = 0;
        private int rounds;
        private int minutes;

        private void GetEntities()
        {
            var data = new DataEntity();
            data.Load();
            entities = data.entitiesLoaded;

            foreach (var entityInCache in entitiesCache)
            {
                if (entities.Contains(entityInCache))
                {
                    entities.Remove(entityInCache);
                }
            }

            if (entities.Count == 0)
                entities = data.entitiesLoaded;
        }

        private void CalculateScore()
        {
            minutes = timer.GetTime();
            score += 100 - ((rounds - 1) * 10) - minutes;
        }

        private void AddLeaderBoard()
        {
            var data = new DataLeaderBoard();
            data.Load();

            if (data.playersLoaded.Count < 10)
            {
                GameView.AddLeaderBoard();

                string name = Console.ReadLine() ?? "";
                name.Trim();

                if (string.IsNullOrEmpty(name))
                    name = "guess";

                if (name.Length > 10)
                        name.Remove(name[10], name.Length - 10);

                data.playersLoaded.Add(new Player(name, score));
                data.playersToSave = data.playersLoaded;
                data.Save();
                score = 0;
                return;
            }

            if (score > data.playersLoaded.Last().score)
            {
                GameView.AddLeaderBoard();

                string name = Console.ReadLine() ?? "";
                name.Trim();

                if (string.IsNullOrEmpty(name))
                    name = "guess";

                if (name.Length > 10)
                        name.Remove(name[10], name.Length - 10);

                data.playersLoaded.Remove(data.playersLoaded.Last());
                data.playersLoaded.Add(new Player(name, score));
                data.playersToSave = data.playersLoaded;
                data.Save();
                score = 0;
            }
        }

        public void Start()
        {
            rounds = 1;
            GetEntities();

            var index = random.Next(0, entities.Count);
            var entity = entities[index];

            entitiesCache.Add(entity);

            GameView.NewGame(entity.categoria);

            ClickEnter.Press();

            InGame(entity);
        }

        public void InGame(Entity entity)
        {
            timer.Start();
            int attempts = entity.dicas.Count;

            for (int i = attempts; i > 0; i--)
            {
                var index = random.Next(0, entity.dicas.Count);
                GameView.inGame(rounds, entity.dicas[index]);
                entity.dicas.Remove(entity.dicas[index]);

                var input = Console.ReadLine() ?? "";

                if (!string.IsNullOrEmpty(input))
                {
                    if (input.ToLower() == entity.resposta.ToLower())
                    {
                        //Venceu
                        timer.Stop();
                        CalculateScore();
                        GameView.Win(entity.resposta, rounds, score);
                        ClickEnter.Press();
                        AddLeaderBoard();
                        return;
                    }

                    //Errou
                    GameView.Miss(rounds);
                    input = Console.ReadLine() ?? "";

                    if (input.ToLower() == "desistir")
                    {
                        score = 0;
                        GameView.GiveUp(entity.resposta, score);

                        ClickEnter.Press();

                        return;
                    }
                }
                rounds++;
            }

            score = 0;
            GameView.GameOver(entity.resposta, score);
            
            ClickEnter.Press();
        }
    }
}
