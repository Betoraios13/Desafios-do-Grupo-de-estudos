using System;
using scripts.View;
using scripts.Controller.game;

namespace mainProgram;

public class Program
{
    public static void Main()
    {
        Game game = new();
        Menu menu = new
        (
            "|         QUEM SOU EU?          |",
            "Jogar\t\t",
            "Ajuda\t\t",
            "Ver leaderboard\t",
            "Sair\t\t\t"
        );

        while (true)
        {
            menu.Show();

            switch (menu.choice)
            {
                case "jogar" or "1":
                    game.Start();
                    break;
                case "ajuda" or "2":
                    Help.Show();
                    break;
                case "ver leaderboard" or "3":
                    LeaderBoard.Show();
                    break;
                case "sair" or "4":
                    break;
                default:
                    InvalidInput.Show();
                    break;
            }

            bool condition = (menu.choice == "sair" || menu.choice == "4");

            if (condition)
            {
                if (WantToLeave())
                {
                    break;
                }

                continue;
            }
        }

        Console.Clear();
        Console.WriteLine("+-------------------------------+");
        Console.WriteLine("|        FIM DO PROGRAMA        |");
        Console.WriteLine("+-------------------------------+");
    }

    private static bool WantToLeave()
    {
        Console.Clear();

        Console.WriteLine("+--------------------------+");
        Console.WriteLine("|      DESEJA SAIR?        |");
        Console.WriteLine("+--------------------------+");
        Console.WriteLine("Tem certeza que deseja sair?");
        Console.WriteLine("1. Sim");
        Console.WriteLine("2. Não");

        Console.Write("\nEscolha uma opção: ");

        while (true)
        {
            var input = Console.ReadLine() ?? "";

            switch (input.ToLower())
            {
                case "sim" or "1":
                    return true;
                case "não" or "2":
                    return false;
                default:
                    continue;
            }
        }
    }
}
