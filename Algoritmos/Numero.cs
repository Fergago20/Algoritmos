using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class Numero
    {
        List<int> Num = new List<int>();
        public void Adaptar(List<int> num)
        {
            Num=num;
        }
        public List<int> Mostrar()
        {
            return Num;
        }
    }
}
