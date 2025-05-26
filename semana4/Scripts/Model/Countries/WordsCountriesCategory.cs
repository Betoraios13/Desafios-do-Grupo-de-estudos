using System;
using System.Collections.Generic;

namespace semana4.Scripts.Model
{
    public class WordsCountriesCategory : Words
    {
        protected override List<string> AvailableWords() => _countries;
    }
}