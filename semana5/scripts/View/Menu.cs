using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace scripts.View
{
    public class Menu
    {
        private string Title = string.Empty;
        private List<string> Options = new();
        public string choice { get; set; } = string.Empty;

        public Menu(string Title, params string[] Options)
        {
            this.Title = Title;
            this.Options = Options.ToList();
        }

        private void WriteOptions()
        {
            for (int i = 0; i < Options.Count; i++)
            {
                Console.Write($"|\t{i + 1}. ");
                Console.Write(Options[i]);
                Console.Write("|\n");
            }
        }

        public void Show()
        {
            Console.Clear();

            Console.WriteLine("+-------------------------------+");
            Console.WriteLine($"{Title}");
            Console.WriteLine("+-------------------------------+");

            WriteOptions();

            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("+-------------------------------+");

            string input = Console.ReadLine() ?? "";

            this.choice = input;
        }
    }
}