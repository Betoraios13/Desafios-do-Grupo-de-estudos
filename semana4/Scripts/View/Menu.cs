using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana4.Scripts.View
{
    public class Menu
    {
        public int choice { get; private set; }
        public string choiceName { get; private set; } = string.Empty;

        private int selection;
        public void CreateMenu(string name, bool randomButton, bool backButton,  params List<string> options)
        {
            ConsoleKey consoleKey;

            var RandomButtonTxt = "Aleatório";
            if (randomButton)
                options.Add(RandomButtonTxt);

            var backButtonTxt = "Voltar";
            if (backButton)
                options.Add(backButtonTxt);

            do
            {
                Console.Clear();

                Console.WriteLine("====================================================================");
                Console.WriteLine(name);
                Console.WriteLine("====================================================================\n");

                for (int i = 0; i < options.Count; i++)
                {
                    if (i == selection)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine($"{options[i]}\n");
                    Console.ResetColor();
                }

                Console.WriteLine("\n====================================================================");
                Console.WriteLine("====================================================================");


                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                consoleKey = keyInfo.Key;

                if(consoleKey == ConsoleKey.UpArrow)
                {
                    selection--;

                    if(selection < 0)
                    {
                        selection = options.Count - 1;
                    }
                }
                else if(consoleKey == ConsoleKey.DownArrow)
                {
                    selection++;

                    if(selection > options.Count - 1)
                    {
                        selection = 0;
                    }
                }

            } while (consoleKey != ConsoleKey.Enter);

            if(randomButton)
            {
                bool itWasTheRandomButton = selection == options.IndexOf(RandomButtonTxt);

                if (itWasTheRandomButton)
                {
                    Random random = new();

                    choice = random.Next(0, selection - 1);
                    return;
                }
            }

            choice = selection;
            choiceName = options[selection];
        }
    }
}
