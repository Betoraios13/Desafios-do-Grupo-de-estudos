using System;
using System.Collections.Generic;
using NeuroLabs.scripts.CreateMenu;
using scripts.Game;

public class Program
{
    public static void Main()
    {
        var menu = new Menu();
        menu.CreateMenu(true, "\t\t\tJogo Caça o Número", "\tComeçar Jogo", "\tSair");

        if(menu.choice == 0)
        {
            var game = new Game();
            game.StartGame();
        }

        Console.WriteLine("===============================================================");
        Console.WriteLine("\t\t\tFim de jogo");
        Console.WriteLine("===============================================================");
    }
}