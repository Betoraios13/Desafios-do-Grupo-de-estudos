namespace scripts.Model
{
    public class Player
    {
        public string name { get; set; } = string.Empty;
        public int score { get; set; }

        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }
}