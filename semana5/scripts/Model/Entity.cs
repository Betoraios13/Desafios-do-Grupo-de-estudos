using System;
using System.Collections.Generic;

namespace scripts.Model
{
    public class Entity
    {
        public string categoria { get; private set; } = string.Empty;
        public string resposta { get; private set; } = string.Empty;
        public List<string> dicas { get; private set; } = new();

        public Entity(string categoria, string resposta, List<string> dicas)
        {
            this.categoria = categoria;
            this.resposta = resposta;
            this.dicas = dicas;
        }
    }
}
