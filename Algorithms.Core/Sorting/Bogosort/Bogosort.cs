using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Sorting.Bogosort
{
    public class Bogosort : SortAlgorithm
    {
        public override string Name => "Bogosort";

        private static bool IsSorted(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                    return false;
            }

            return true;
        }

        private static int[] RandomPermutation(int[] a)
        {
            Random random = new Random();
            var n = a.Length;
            while (n > 1)
            {
                n--;
                var i = random.Next(n + 1);
                (a[n], a[i]) = (a[i], a[n]);
            }

            return a;
        }

        public override int[] Sort(int[] array)
        {
            while (!IsSorted(array))
            {
                array = RandomPermutation(array);
            }
            return array;
        }
    }
}