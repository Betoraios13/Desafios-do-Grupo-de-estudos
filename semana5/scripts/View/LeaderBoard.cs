using scripts.Model.data;
using scripts.Model;
using scripts.Controller.controls;

namespace scripts.View
{
    public static class LeaderBoard
    {
        public static List<Player> players = new();
        public static void Show()
        {

            Console.Clear();

            Console.WriteLine("+----------------------------------------+");
            Console.WriteLine("|              LEADERBOARD               |");
            Console.WriteLine("+----------------------------------------+");

            GetPrintList();

            Console.WriteLine("Pressione ENTER para voltar.");

            ClickEnter.Press();
        }

        private static void GetPrintList()
        {
            var data = new DataLeaderBoard();
            data.Load();
            players = data.playersLoaded;

            if (players.Count == 0)
                Console.WriteLine("Sem players na lista");

            for (int i = 0; i < players.Count; i++)
            {
                var name = players[i].name;
                var score = players[i].score;

                Console.WriteLine($"{i + 1}. {name} \t -\t {score}");
            }
        }      
    }
}
