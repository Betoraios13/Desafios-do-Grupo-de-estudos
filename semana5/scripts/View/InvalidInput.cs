using scripts.Controller.controls;

namespace scripts.View
{
    public static class InvalidInput
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine("+-----------------------------------+");
            Console.WriteLine("|            OPÇÃO INVÁLIDA         |");
            Console.WriteLine("+-----------------------------------+");

            Console.WriteLine("Por favor, escolha uma opção válida.\n");

            Console.WriteLine("Pressione ENTER para voltar ao menu");

            ClickEnter.Press();
        }
    }
}
