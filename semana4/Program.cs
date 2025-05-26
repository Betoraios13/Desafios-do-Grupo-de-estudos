using semana4.Scripts.Controller;
using semana4.Scripts.View;
using System;

public class Program
{
    public static void Main()
    {
        Menu menu = new();
        Game game = new();

        do
        {
            menu.CreateMenu("\t\t\tJOGO DA FORCA!", false, false, "\t\t\tStart", "\t\t\tExit");

            if (menu.choice == 0)
            {
                game.Start();
            }

        } while (menu.choice != 1);
        
        Console.Clear();
        Console.WriteLine("====================================================================");
        Console.WriteLine("\t\t\tFim do Programa");
        Console.WriteLine("====================================================================");
    }
}