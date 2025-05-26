using semana4.Scripts.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana4.Scripts.Controller.Input
{
    public static class CheckInput
    {
        public static string Check(string answer, Historic hisLetters, Historic hisWords)
        {
            if (answer == "sair")
                return "exit";

            bool isLetter = (answer.Length == 1 && char.IsLetter(answer[0]));

            var list = isLetter ? hisLetters._stringList : hisWords._stringList;

            var typeKick = isLetter ? "letra" : "palavra";

            if (!list.Contains(answer))
            {
                list.Add(answer.ToLower());
                return "valid";
            }
            else if (list.Contains(answer.ToLower()))
            {
                Console.Clear();
                Console.WriteLine($"\nVocê Já chutou essa {typeKick}");
                Console.WriteLine("\nAperte qualquer tecla para continuar: ");
                Console.ReadKey();
                return "repeated";
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Entrada inválida! (se quiser sair digite 'sair')");
                Console.WriteLine("\nAperte qualquer tecla para continuar: ");
                Console.ReadKey();
                return "invalid";
            }
        }
    }
}
