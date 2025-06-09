using System.Text.Json;
using scripts.Model.data.paths;
using scripts.Model;

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
            var random = new Random();
            string fileName = $"category{random.Next(1, 4)}.json";
            string path = Path.Combine(Paths.PATH_FOR_ENTITIES, fileName);

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                entitiesLoaded = JsonSerializer.Deserialize<List<Entity>>(json) ?? new();
                return;
            }

            Console.WriteLine("Arquivo ausente");
            Environment.Exit(0);
        }
    }
}
