using System.Text.Json;
using scripts.Model.data.paths;
using scripts.Model;
using System.Diagnostics;

namespace scripts.Model.data
{
    public class DataEntity : Data
    {
        public List<Entity> entitiesLoaded = new();
        public override void Save()
        {
            throw new NotImplementedException();
        }

        public override void Load()
        {
            string fileExtension = "*.json";
            string[] files = Directory.GetFiles(Paths.PATH_FOR_ENTITIES, fileExtension);

            if (Directory.Exists(Paths.PATH_FOR_ENTITIES))
            {
                foreach (var file in files)
                {
                    string json = File.ReadAllText(file);
                    entitiesLoaded.AddRange(JsonSerializer.Deserialize<List<Entity>>(json) ?? new());
                }
                return;
            }

            Console.WriteLine("Arquivos ou caminho ausente");
            Environment.Exit(0);
        }
    }
}
