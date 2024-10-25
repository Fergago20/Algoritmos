using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class MergeSort
    {
        public void fMergeSort(List<int> numeros, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                fMergeSort(numeros, left, mid);
                fMergeSort(numeros, mid + 1, right);
                Merge(numeros, left, mid, right);
            }
        }

        public void Merge(List<int> numeros, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            List<int> numeros1 = new List<int>();
            List<int> numeros2 = new List<int>();

            for (int i = 0; i < n1; i++)
            {
                numeros1.Add(numeros[left + i]);
            }

            for (int j = 0; j < n2; j++)
            {
                numeros2.Add(numeros[mid + 1 + j]);
            }

            int i1 = 0;
            int j1 = 0;
            int k = left;

            while (i1 < n1 && j1 < n2)
            {
                if (numeros1[i1] <= numeros2[j1])
                {
                    numeros[k] = numeros1[i1];
                    i1++;
                }
                else
                {
                    numeros[k] = numeros2[j1];
                    j1++;
                }
                k++;
            }
            while (i1 < n1)
            {
                numeros[k] = numeros1[i1];
                i1++;
                k++;
            }

            
            while (j1 < n2)
            {
                numeros[k] = numeros2[j1];
                j1++;
                k++;
            }
        }
    }
}
