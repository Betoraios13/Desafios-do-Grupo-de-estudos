using System;
using System.Collections.Generic;

namespace scripts.Model
{
    public class Entity
    {
        public string category { get; private set; } = string.Empty;
        public string answer { get; private set; } = string.Empty;
        public List<string> clues { get; private set; } = new();

        public Entity(string category, string answer, List<string> clues)
        {
            this.category = category;
            this.answer = answer;
            this.clues = clues;
        }
    }
}
