using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana4.Scripts.View
{
    public class Historic
    {
        private string _historicLabel;
        public List<string> _stringList = new();
        public Historic(string historicLabel)
        {
            this._historicLabel = historicLabel;
        }

        public void Print()
        {
            if (this._stringList.Count == 0)
                return;

            Console.Write($"{this._historicLabel}: [ ");

            foreach (var c in this._stringList)
            {
                if (c != this._stringList.Last())
                {
                    Console.Write($"{c} , ");
                }
                else
                {
                    Console.Write($"{c} ]\n");
                }
            }
        }
    }
}
