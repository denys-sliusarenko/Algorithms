using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Sorting.BubbleSort
{
    public class BubbleSort<T> : ISortAlgorithm<T> where T : IComparable<T>
    {
        public string Name => "Bubble sort";
        public T[] Sort(T[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }

        private static void Swap(ref T e1, ref T e2)
        {
            (e2, e1) = (e1, e2);
        }
    }
}
