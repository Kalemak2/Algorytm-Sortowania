using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Sort {
        public static void MaxNumber()
        {
            int maxlenght = 10;
            int n = 0;
            int[] ints = new int[10];
            while (n < maxlenght)
            {
                Console.Write($"Podaj {n + 1} liczbe:");
                ints[n] = Convert.ToInt32(Console.ReadLine());
                n = n + 1;
            }

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
            foreach (var d in ints)
            {
                Console.WriteLine(d);
            }
        }
        static void SelectionSort(int[] ints, int maxIndex, int i)
        {
            int temp = ints[i];
            ints[i] = ints[maxIndex];
            ints[maxIndex] = temp;
        }
    }
}
