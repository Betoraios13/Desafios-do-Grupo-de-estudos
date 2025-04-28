using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusFlow
{
    public class Activity
    {
        private float userTime;
        public Activity(float userTime)
        {
            this.userTime = userTime;
        }
        public void GetSuggestion()
        {
            while(userTime >= 5)
            {
                SelectSuggestion();
            }
        }
        private void SelectSuggestion()
        {
            switch (userTime) 
            {
                case float n when(n >= 90):
                    Console.WriteLine("\nVocê poderia: ");
                    Console.WriteLine(GreaterThanNinetyMinutes());
                    Console.WriteLine($"E restam {userTime} minutos\n");
                    break;
                case float n when (n >= 45):
                    Console.WriteLine("\nVocê poderia: ");
                    Console.WriteLine(FortyFiveMinute());
                    Console.WriteLine($"E restam {userTime} minutos\n");
                    break;
                case float n when (n >= 20):
                    Console.WriteLine("\nVocê poderia: ");
                    Console.WriteLine(TwentyMinutes());
                    Console.WriteLine($"E restam {userTime} minutos\n");
                    break;
                case float n when (n >= 10):
                    Console.WriteLine("\nVocê poderia: ");
                    Console.WriteLine(TenMinutes());
                    Console.WriteLine($"E restam {userTime} minutos\n");
                    break;
                case float n when (n >= 5):
                    Console.WriteLine("\nVocê poderia: ");
                    Console.WriteLine(FiveMinutes());
                    Console.WriteLine($"E restam {userTime} minutos\n");
                    break;
            }
        }

        private string FiveMinutes()
        {
            List<string> actions = new ()
            {
                "beber água", "levantar e alongar", "respirar fundo", "enviar uma mensagem para alguém querido",
                "organizar a mesa de trabalho", "fazer um checklist rápido"
            };

            userTime -= 5;

            Random random = new Random();
            int index = random.Next(0, actions.Count);

            string action = actions[index];

            return action;
        }

        private string TenMinutes()
        {
            List<string> actions = new()
            {
                "ler um artigo curto", "revisar anotações", "meditar", "planejar o próximo dia", 
                "ouvir uma música relaxante", "fazer uma pausa consciente"
            };

            userTime -= 10;

            Random random = new Random();
            int index = random.Next(0, actions.Count);

            string action = actions[index];

            return action;
        }
        private string TwentyMinutes()
        {
            List<string> actions = new()
            {
                "Assitir a uma vídeo aula", "fazer uma caminhada curta", "preparar um lanche saudável",
                "revisar flashcards", "praticar uma habilidade rápida (como esboçar algo ou tocar um instrumento)."
            };

            userTime -= 20;

            Random random = new Random();
            int index = random.Next(0, actions.Count);

            string action = actions[index];

            return action;
        }
        private string FortyFiveMinute()
        {
            List<string> actions = new()
            {
                "estudar um módulo", "escrever um texto", "resolver exercícios", "aprofundar-se em um capítulo de livro",
                "praticar exercícios físicos moderados"
            };

            userTime -= 45;

            Random random = new Random();
            int index = random.Next(0, actions.Count);

            string action = actions[index];

            return action;
        }
        private string GreaterThanNinetyMinutes()
        {
            List<string> actions = new()
            {
                "projeto pessoal", "estudo aprofundado", "tarefa doméstica longa", "aprender uma nova habilidade prática",
                "criar um protótipo"
            };

            userTime -= 90;

            Random random = new Random();
            int index = random.Next(0, actions.Count);

            string action = actions[index];

            return action;
        }
    }
}
