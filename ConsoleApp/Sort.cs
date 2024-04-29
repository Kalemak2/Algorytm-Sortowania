using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Sort {

        /************************************** 
        nazwa funkcji:        MaxNumber
        parametry wejściowe:  ints - tablica liczb całkowitych do posortowania
        wartość zwracana:     posortowana tablica liczb całkowitych w malejącej kolejności
        autor:                Kornel Pakulski
        *************************************/
        public static int[] MaxNumber(int[] ints)
        {
            for (int i = 0; i < ints.Length - 1; i++)
            {
                int max = ints[i];
                int maxIndex = i;
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (ints[j] > max)
                    {
                        max = ints[j];
                        maxIndex = j;
                    }
                }
                SelectionSort(ints, maxIndex, i);
            }
            return ints;
        }
        static void SelectionSort(int[] ints, int maxIndex, int i)
        {
            int temp = ints[i];
            ints[i] = ints[maxIndex];
            ints[maxIndex] = temp;
        }
    }
}
