using System;

namespace scripts.Controller.controls
{
    public static class ClickEnter
    {
        private static ConsoleKey inputKey;
        public static void Press()
        {
            do
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                inputKey = info.Key;

            } while (inputKey != ConsoleKey.Enter);
        }
    }
}