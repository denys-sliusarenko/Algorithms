using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Sorting.BubbleSort
{
    public class BubbleSort : SortAlgorithm
    {
        public override string Name => "Bubble sort";

        private static void Swap(ref int e1, ref int e2)
        {
            (e2, e1) = (e1, e2);
        }

        public override int[] Sort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
    }
}
