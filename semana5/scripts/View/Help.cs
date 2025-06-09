using System;
using scripts.Controller.controls;

namespace scripts.View
{
    public static class Help
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine("+---------------------------------------------------+");
            Console.WriteLine("|                       AJUDA                       |");
            Console.WriteLine("+---------------------------------------------------+");

            Console.WriteLine("Regras do jogo:");
            Console.WriteLine("- Adivinhe quem é com até 10 dicas.");
            Console.WriteLine("- Cada dica: −10 pts.");
            Console.WriteLine("- Cada minuto: −1 pt.");
            Console.WriteLine("- Digite 'desistir' para encerrar o desafio atual.");

            Console.WriteLine("\nPressione ENTER para voltar ao menu.");

            ClickEnter.Press();
        }
    }
}