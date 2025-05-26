using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using semana4.Scripts.Controller.Input;
using semana4.Scripts.Model;
using semana4.Scripts.View;

namespace semana4.Scripts.Controller
{
    public class Game
    {
        private string _secretWord = string.Empty;
        private string _secretWordInUI = string.Empty;
        public void Start()
        {
            var AllWords = new AllWordCategorys();
            var animalWords = new WordsAnimalCategory();
            var countrieWords = new WordsCountriesCategory();
            var foodWords = new WordsFoodCategory();
            var partOfBodyWords = new WordsPartOfBodyCategory();
            var verbWords = new WordsVerbsCategory();

            var menu = new Menu();
            
            while (true) { 
                menu.CreateMenu
                    (
                        "\t\tQUER JOGAR? ESCOLHA A CATEGORIA",
                        randomButton: true,
                        backButton: true,
                        "\t\t\tAnimais",
                        "\t\t\tPaíses",
                        "\t\t\tComidas",
                        "\t\t\tParte do Corpo",
                        "\t\t\tVerbos",
                        "\t\t\tTudo"
                    );

                var playerChoice = new Dictionary<int, (string theme, string secretWord)>()
                {
                    {0, (menu.choiceName, animalWords.GetWord()) },
                    {1, (menu.choiceName, countrieWords.GetWord()) },
                    {2, (menu.choiceName, foodWords.GetWord()) },
                    {3, (menu.choiceName, partOfBodyWords.GetWord()) },
                    {4, (menu.choiceName, verbWords.GetWord()) },
                    {5, (menu.choiceName, AllWords.GetWord()) }
                };

                if (playerChoice.TryGetValue(menu.choice, out (string theme, string word) values))
                {
                    _secretWord = values.word;
                    InGame(values.theme);
                    continue;
                }
                else
                {
                    return;
                }
            }
        }

        private void InGame(string theme)
        {
            var hisLetters = new Historic("Letras chutadas"); 
            var hisWords = new Historic("Palavras chutadas");

            int attempts = 6;

            while (attempts > 0)
            {
                Console.Clear();

                Console.WriteLine("====================================================================");
                Console.WriteLine($"\t\t\tO tema da forca: {theme.Trim()}");
                Console.WriteLine("====================================================================\n");

                UpdateSecretWord(hisLetters._stringList);
                Console.WriteLine($"Palavra Secreta: {_secretWordInUI}\n");

                hisLetters.Print();
                hisWords.Print();

                Console.WriteLine($"Tentativas restantes: {attempts}");

                Console.Write("\nChute a palavra ou uma letra: ");
                var answer = Console.ReadLine() ?? "";

                
                switch (CheckInput.Check(answer, hisLetters, hisWords)) 
                {
                    case "valid":
                        break;
                    case "repeated":
                        continue;
                    case "invalid":
                        continue;
                    case "exit":
                        return;
                }

                if (CheckAnswer(answer) == "win")
                    return;

                attempts--;
            }

            Console.Clear();
            Console.WriteLine("=======================================================================");
            Console.WriteLine($"Infelizmente Você Perdeu... A Palavra Secreta era {_secretWord}");
            Console.WriteLine("=======================================================================");

            Console.WriteLine("\nAperte qualquer tecla para continuar: ");
            Console.ReadKey();
        }
        private string CheckAnswer(string answer)
        {
            if(answer.ToLower() == _secretWord.ToLower())
            {
                Console.Clear();
                Console.WriteLine("=======================================================================");
                Console.WriteLine($"!!Parabéns!! Você Ganhou!! A Palavra Secreta era {_secretWord}");
                Console.WriteLine("=======================================================================");

                Console.WriteLine("\nAperte qualquer tecla para continuar: ");
                Console.ReadKey();
                return "win";
            }

            return "";
        }

        private void UpdateSecretWord(List<string> historicOfLetters)
        {
            if (historicOfLetters.Count == 0) 
            { 
                _secretWordInUI = new string(_secretWord.Select(c => char.IsLetter(c) ? '_' : c).ToArray()).ToLower();
                return;
            }

            var localSecretWord = _secretWord.ToLower();

            for (int i = 0; i < localSecretWord.Length; i++)
            {
                if (localSecretWord[i] == historicOfLetters.Last()[0])
                {
                    var listToReveal = _secretWordInUI!.ToCharArray();

                    listToReveal[i] = localSecretWord[i];

                    _secretWordInUI = string.Empty;

                    foreach (char c2 in listToReveal)
                    {
                        _secretWordInUI += c2;
                    }
                }
            }
        }
    }
}
