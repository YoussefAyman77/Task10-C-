using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class SortingAlgorithm<T> where T : IComparable<T> , ICloneable
    {
        public static void Sort(T[] items)
        {
            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = 0; j < items.Length - 1 - i; j++)
                {
                    if (items[j].CompareTo(items[j + 1]) == 1)
                    {
                        Swap(ref items[j], ref items[j + 1]);
                    }
                }
            }
        }

        public static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
