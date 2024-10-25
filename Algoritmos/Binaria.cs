using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class Binaria
    {
        public int BusquedaBinaria(List<int> numeros, int valorBuscado)
        {
            int bajo = 0;
            int alto = numeros.Count - 1;

            while (bajo <= alto)
            {
                int medio = bajo + (alto - bajo) / 2;

                
                if (numeros[medio] == valorBuscado)
                {
                    return medio; 
                }

                
                if (numeros[medio] < valorBuscado)
                {
                    bajo = medio + 1;
                }
                
                else
                {
                    alto = medio - 1;
                }
            }

            
            return -1;
        }
    }
}
