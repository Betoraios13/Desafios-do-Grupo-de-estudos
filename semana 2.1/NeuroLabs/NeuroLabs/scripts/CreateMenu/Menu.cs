using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroLabs.scripts.CreateMenu
{
    public class Menu
    {
        public int choice;
        public void CreateMenu(bool clearConsole, string title, params string[] options)
        {
            ConsoleKey consoleKey;
            int selection = 0;

            do
            {
                if (clearConsole)
                    Console.Clear();

                Console.WriteLine("===============================================================");
                Console.WriteLine(title);
                Console.WriteLine("===============================================================\n");

                for (int i = 0; i < options.Length; i++)
                {
                    if(i == selection)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine($"{options[i]}");
                    Console.ResetColor();
                }

                Console.WriteLine("===============================================================");

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                consoleKey = keyInfo.Key;

                if(consoleKey == ConsoleKey.UpArrow)
                {
                    selection--;

                    if(selection < 0)
                    {
                        selection = options.Length - 1;
                    }
                }
                else if(consoleKey == ConsoleKey.DownArrow)
                {
                    selection++;

                    if(selection > options.Length - 1)
                    {
                        selection = 0;
                    }
                }

            } while (consoleKey != ConsoleKey.Enter);

            this.choice = selection;
        }
    }
}
