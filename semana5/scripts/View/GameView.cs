using System;

namespace scripts.View
{
    public static class GameView
    {
        public static void NewGame(string category)
        {
            Console.Clear();

            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|             NOVO DESAFIO             |");
            Console.WriteLine("+--------------------------------------+");

            Console.WriteLine($"Categoria: {category}");

            Console.WriteLine("\nPressione ENTER para ver a dica 1.");
        }

        public static void inGame(int rounds, string clue)
        {
            string title;
            string answerLabel;
            if (rounds < 10)
            {
                title = $"|           DICA {rounds}            |";
                answerLabel = "\nDigite sua resposta ou \npressione ENTER para próxima:";
            }
            else
            {
                title = "|           FIM DE JOGO           |";
                answerLabel = "Digite sua resposta final:";
            }

            Console.Clear();
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine(title);
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine($"{clue}.");

            Console.WriteLine(answerLabel);
            Console.Write("> ");
        }

        public static void Miss(int round)
        {
            Console.WriteLine("\n❌ Resposta incorreta!");
            Console.WriteLine($"\nPressione ENTER para dica {round}.");

            if (round == 1)
                Console.WriteLine("(ou digite \"desistir\" para sair)");

        }

        public static void Win(string answer, int round, int score)
        {
            Console.WriteLine("\n✅ Correto!");
            Console.WriteLine($"Resposta: **{answer}**");

            Console.WriteLine($"Dicas usadas: {round}");
            Console.WriteLine($"Pontuação: {score} pts");

            Console.WriteLine("\nPressione ENTER para menu.");
        }

        public static void GiveUp(string answer, int score)
        {
            Console.WriteLine("\n💀 Você desistiu!");
            Console.WriteLine($"Resposta certa: **{answer}**");
            Console.WriteLine($"Pontuação: {score} pts");

            Console.WriteLine("\nPressione ENTER para menu");
        }

        public static void GameOver(string answer, int score)
        {
            Console.WriteLine("\n❌ Resposta incorreta!");

            Console.WriteLine("\n💀 Fim de jogo!");
            Console.WriteLine($"Resposta certa: **{answer}**");
            Console.WriteLine("Você usou todas as dicas.");
            Console.WriteLine($"Pontuação: {score} pts");

            Console.WriteLine("\nPressione ENTER para menu.");
        }

        public static void AddLeaderBoard()
        {
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("|     NOVA PONTUÇÂO ALTA!     |");
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("Parabéns! Você ficou no top 10.");

            Console.WriteLine("\nDigite seu nome (máx 10 caracteres):");
            Console.Write("> ");
        }
    }
}