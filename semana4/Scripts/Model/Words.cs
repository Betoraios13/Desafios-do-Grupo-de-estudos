using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana4.Scripts.Model
{
    public abstract class Words
    {
        protected abstract List<string> AvailableWords();

        protected readonly List<string> _animals = new()
        {
            "Abelha", "Polvo", "Caranguejo", "Agua-viva",
            "Leao", "Elefante", "Tigre", "Urso-pardo", "Panda",
            "Cavalo", "Cachorro", "Gato", "Golfinho", "Arara",
            "Chimpanze", "Aguia", "Pinguim", "Papagaio", "Coruja",
            "Baleia", "Orangotango", "Lobo", "Canguru", "Girafa",
            "Tartaruga", "Camaleao", "Tubarao", "Peixe-palhaco", "Piranha",
            "Pavao", "Andorinha", "Flamingo", "Cobra-real", "Crocodilo", "Jararaca",
            "Cavalo-marinho", "Salmao", "Ra", "Sapo", "Axolote", "Borboleta",
        };

        protected readonly List<string> _partsOfBody = new()
        {
            "Cabeca", "Olhos", "Orelha", "Boca", "Nariz", "Cabelo",
            "Pescoco", "Ombro", "Braco", "Cotovelo", "Pulso", "Mao",
            "Dedo", "Peito", "Barriga", "Costas", "Cintura", "Quadril",
            "Perna", "Coxa", "Joelho", "Tornozelo", "Pe", "Calcanhar",
            "Dedao", "Lingua", "Dente", "Sobrancelha", "Palpebra", "Unha",
            "Nadega", "Intestino", "Estomago", "Pulmao", "Coracao", "Figado",
            "Rim", "Vesicula", "Vagina", "Penis", "Utero", "Esofago", "Laringe",
            "Traqueia", "Veia", "Arteria", "Musculo", "Osso", "Pele",
        };

        protected readonly List<string> _countries = new()
        {
            "Brasil", "Estados Unidos", "Canada", "Mexico", "Argentina",
            "Alemanha", "Franca", "Reino Unido", "Italia", "Espanha",
            "Portugal", "Australia", "Nova Zelandia", "Japao", "China",
            "Coreia do Sul", "India", "Russia", "Africa do Sul", "Egito",
            "Nigeria", "Marrocos", "Arabia Saudita", "Ira", "Turquia",
            "Grecia", "Suecia", "Noruega", "Finlandia", "Dinamarca",
            "Polonia", "Ucrania", "Paquistao", "Indonesia", "Filipinas",
            "Tailandia", "Vietna", "Malasia", "Singapura", "Israel", "Cuba",
            "Colombia", "Chile", "Peru", "Venezuela", "Bolivia", "Paraguai",
            "Uruguai", "Coreia do Norte", "Cazaquistao",
        };

        protected readonly List<string> _foods = new()
        {
            "Maca", "Banana", "Laranja", "Manga", "Abacaxi", "Melancia", "Uva",
            "Morango", "Limao", "Coco", "Tomate", "Alface", "Cenoura", "Beterraba",
            "Brocolis", "Espinafre", "Batata", "Batata-doce", "Abobora", "Pepino",
            "Feijao", "Arroz", "Milho", "Trigo", "Soja", "Carne bovina", "Frango",
            "Peixe", "Carne de porco", "Ovo", "Presunto", "Salsicha", "Queijo",
            "Leite", "Iogurte", "Pao", "Pizza", "Hamburguer", "Cachorro-quente",
            "Sanduiche", "Pastel", "Coxinha", "Empada", "Lasanha", "Espaguete",
            "Macarrao", "Sushi", "Torta", "Bolo", "Sorvete", "Chocolate", "Biscoito",
            "Pudim",
        };

        protected readonly List<string> _verbs = new() 
        {
            "Comer", "Beber", "Andar", "Correr", "Pular", "Falar", "Ouvir",
            "Ver", "Olhar", "Pensar", "Dormir", "Acordar", "Trabalhar",
            "Estudar", "Ler", "Escrever", "Comprar", "Vender", "Cozinhar",
            "Lavar", "Limpar", "Abrir", "Fechar", "Entrar", "Sair", "Sentar",
            "Levantar", "Brincar", "Jogar", "Cantar", "Dançar", "Nadar", "Chorar",
            "Sorrir", "Gostar", "Amar", "Odiar", "Sentir", "Esperar", "Ajudar",
            "Pensar", "Conseguir", "Precisar", "Tentar", "Viajar", "Chegar",
            "Partir", "Ligar", "Desligar", "Ficar", "Mudar"
        };

        public virtual string GetWord()
        {
            Random random = new();
            int index = random.Next(0, this.AvailableWords().Count - 1);
            return this.AvailableWords()[index];
        }
    }
}
