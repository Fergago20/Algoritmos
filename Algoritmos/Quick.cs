using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class Quick
    {
        public void QuickSort(List<int> numeros, int low, int high)
        {
            if (low < high)
            {
                
                int pi = Partition(numeros, low, high);

                
                QuickSort(numeros, low, pi - 1);
                QuickSort(numeros, pi + 1, high);
            }
        }

        static int Partition(List<int> numeros, int low, int high)
        {
            int pivot = numeros[high]; 
            int i = (low - 1); 

            for (int j = low; j < high; j++)
            {
                
                if (numeros[j] <= pivot)
                {
                    i++; 
                    Swap(numeros, i, j);
                }
            }

            Swap(numeros, i + 1, high); 
            return i + 1; 
        }

        static void Swap(List<int> numeros, int i, int j)
        {
            int temp = numeros[i];
            numeros[i] = numeros[j];
            numeros[j] = temp;
        }
    }
}
