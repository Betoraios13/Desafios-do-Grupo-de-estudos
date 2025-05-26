using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana4.Scripts.Model
{
    public class AllWordCategorys : Words
    {
        protected override List<string> AvailableWords()
        {
            var list = new List<string>();
            list.AddRange(_animals);
            list.AddRange(_countries);
            list.AddRange(_foods);
            list.AddRange(_partsOfBody);
            list.AddRange(_verbs);

            return list;
        }
    }
}
