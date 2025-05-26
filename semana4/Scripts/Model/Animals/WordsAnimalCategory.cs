using System;
using System.Collections.Generic;

namespace semana4.Scripts.Model
{
    public class WordsAnimalCategory : Words
    {
        protected override List<string> AvailableWords() => _animals;
    }
}