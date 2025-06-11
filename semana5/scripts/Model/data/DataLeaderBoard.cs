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
        public List<Player> playersToSave { private get; set; } = new();
        public List<Player> playersLoaded { get; private set; } = new();
        public override void Save()
        {
            playersToSave.Sort((x, y) => x.score.CompareTo(y.score));
            playersToSave.Reverse();
            
            var jsonOptions = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize<List<Player>>(playersToSave, jsonOptions);
            File.WriteAllText(Paths.PATH_FOR_LEADERBOARD, json);
        }

        public override void Load()
        {
            if (File.Exists(Paths.PATH_FOR_LEADERBOARD))
            {
                string json = File.ReadAllText(Paths.PATH_FOR_LEADERBOARD);
                playersLoaded = JsonSerializer.Deserialize<List<Player>>(json) ?? new();
                playersLoaded.Sort((x, y) => x.score.CompareTo(y.score));
                playersLoaded.Reverse();
            }
            else
            {
                Console.WriteLine("Nenhum dado de jogadores encontrado");
            }
        }

    }
}
