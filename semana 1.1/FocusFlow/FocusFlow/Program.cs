using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace FocusFlow.Program
{
    public class Program
    {
        public static float userTime;
        public static void Main()
        {
            StartProgram();
            SetUserTime();

            Console.WriteLine($"\n{userTime} minutos disponíveis\n");

            Activity activity = new Activity(userTime);

            activity.GetSuggestion();

            EndProgram();
        }

        private static void StartProgram()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("             FocusFlow-MicroDecisions           ");
            Console.WriteLine("================================================");
            Console.WriteLine("\n");
        }  
        private static void EndProgram()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("             FocusFlow-MicroDecisions           ");
            Console.WriteLine("            FIM DE EXECUSÃO DO PROGRAMA         ");
            Console.WriteLine("================================================");
            Console.WriteLine("\n");
        }

        private static void SetUserTime()
        {
            try
            {
                Console.WriteLine("Digite seu tempo disponível: ");

                string? time = Console.ReadLine();

                if(time!.All(c => char.IsNumber(c)))
                {
                    userTime = float.Parse(time!);
                    return;
                }

                var hours = GetMatch(time)?.Groups[1].Value ?? "";
                var minutes = GetMatch(time)?.Groups[2].Value ?? "";

                float userHoursTime = float.Parse(hours);
                float userMinutesTime = float.Parse(minutes) + userHoursTime * 60;

                userTime = userMinutesTime;
            }
            catch
            {
                userTime = 0;
                Console.WriteLine("Tempo inválido");
                Console.WriteLine("Tente outra vez usando um desses formatos: ");
                Console.WriteLine("Ex1: 2h00, Ex2: 2:00 ou Ex3: 5 (por padrão em minutos)");
            }
        }

        private static Match? GetMatch(string? input)
        {
            List<string> patterns = new List<string>()
            {
                @"^(\d{1,2})h(\d{2})$",
                @"^(\d{1,2}):(\d{2})$",
            };

            Match match;

            foreach (string pattern in patterns)
            {
                if (Regex.IsMatch(input!, pattern))
                {
                    match = Regex.Match(input!, pattern);
                    return match;
                }
            }

            return null;
        }
    }
}