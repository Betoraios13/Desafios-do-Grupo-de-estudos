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
            "|         QUEM SOU EU??         |",
            "Jogar\t\t",
            "Ajuda\t\t",
            "Ver leaderboard\t",
            "Sair\t\t\t"
        );

        do
        {
            menu.Show();

            switch (menu.choice)
            {
                case "jogar":
                    game.Start();
                    break;
                case "ajuda":
                    Help.Show();
                    break;
                case "ver leaderboard":
                    LeaderBoard.Show();
                    break;
                case "sair":
                    break;
                default:
                    InvalidInput.Show();
                    break;
            }

        } while (menu.choice != "sair");

        Console.Clear();
        Console.WriteLine("+-------------------------------+");
        Console.WriteLine("|        FIM DO PROGRAMA        |");
        Console.WriteLine("+-------------------------------+");
    }
}
