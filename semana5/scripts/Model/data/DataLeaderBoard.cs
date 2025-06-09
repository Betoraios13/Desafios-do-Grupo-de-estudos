using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using scripts.Model.data.paths;
using scripts.Model;

namespace scripts.Model.data
{
    public class DataLeaderBoard : Data
    {
        public List<Player> playersLoaded { get; private set; } = new();
        public override void Save()
        {
            throw new NotImplementedException();
        }

        public override void Load()
        {
            if (File.Exists(Paths.PATH_FOR_LEADERBOARD))
            {
                string json = File.ReadAllText(Paths.PATH_FOR_LEADERBOARD);
                playersLoaded = JsonSerializer.Deserialize<List<Player>>(json) ?? new();
            }
            else
            {
                Console.WriteLine("Nenhum dado de jogadores encontrado");
            }
        }

    }
}
