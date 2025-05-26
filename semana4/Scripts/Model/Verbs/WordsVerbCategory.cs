using System;
using System.Collections.Generic;

namespace semana4.Scripts.Model
{
    public class WordsVerbsCategory : Words
    {
        protected override List<string> AvailableWords() => _verbs;
    }
}