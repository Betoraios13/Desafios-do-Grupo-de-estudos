using NeuroLabs.scripts.CreateMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace scripts.Game
{
    public class Game
    {
        private int score;
        private int rounds;
        private int difficulty;
        private int secretNumber;
        private List<int> historic = new();

        public void StartGame()
        {
            SelectDifficulty();

            Console.Clear();

            while (true) 
            {
                rounds++;
                SetSecretNumber();

                InGame();

                var menu = new Menu();
                menu.CreateMenu(true, "Deseja jogar novamente?", "Sim", "Sair");

                if (menu.choice == 0)
                {
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("===============================================================");
                    Console.WriteLine($"\nVocê jogou {rounds} rodada(s) e acertou {score} vez(es). Até logo!\n");
                    break;
                }     
            }
        }

        private void SelectDifficulty()
        {
            var menu = new Menu();
            menu.CreateMenu
                (
                    true, 
                    "Select Difficulty", 
                    "fácil (0 - 100)", 
                    "normal (0 - 500)", 
                    "difícil (0 - 1000)"
                );

            difficulty = menu.choice;
        }

        private void SetSecretNumber()
        {
            Random random = new Random();

            switch (difficulty)
            {
                case 0:
                    secretNumber = random.Next(0, 100);
                    break;
                case 1:
                    secretNumber = random.Next(0, 500);
                    break;
                case 2:
                    secretNumber = random.Next(0, 1000);
                    break;
            }
        }

        private void InGame()
        {
            int attempts = 10;

            do
            {
                Console.WriteLine($"Tentativas restantes: {attempts}");
                Console.Write("Seu chute: ");

                int guess;

                try
                {
                    guess = int.Parse(Console.ReadLine()!);
                    historic.Add(guess);
                }
                catch
                {
                    Console.WriteLine("\n!!!Digite um valor númerico inteiro > 0!!!\n");
                    continue;
                }

                if(guess == secretNumber)
                {
                    score++;
                    historic.Clear();

                    Console.WriteLine($"\n✅ Você acertou! O número secreto era {secretNumber}.");
                    Console.WriteLine($"🥇Pontuação atual: {score}.\n");

                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    return;
                }

                string moreOrLess = (guess > secretNumber) ? "O número secreto é menor" : "O número secreto é maior";
                PrintHistoric();
                Console.WriteLine(moreOrLess + "\n");
                attempts--;


            } while (attempts > 0);

            historic.Clear();

            Console.WriteLine($"\n❌ Suas tentativas acabaram! O número secreto era {secretNumber}.");
            Console.WriteLine($"🥇Pontuação atual: {score}\n");

            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }

        private void PrintHistoric()
        {
            Console.Write("Números chutados: [ ");

            foreach (var n in historic)
            {
                if (n != historic.Last())
                {
                    Console.Write($"{n} , ");
                }
                else
                {
                    Console.Write($"{n} ]\n");
                }
            }
        }
    }
}