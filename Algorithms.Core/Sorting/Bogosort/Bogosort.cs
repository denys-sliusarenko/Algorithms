using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Sorting.Bogosort
{
    public class Bogosort<T> : ISortAlgorithm<T> where T : IComparable<T>
    {
        public string Name => "Bogosort";

        public T[] Sort(T[] array)
        {
            while (!IsSorted(array))
            {
                array = RandomPermutation(array);
            }
            return array;
        }

        private static bool IsSorted(T[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i].CompareTo(a[i + 1]) > 0)
                    return false;
            }

            return true;
        }

        private static T[] RandomPermutation(T[] a)
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
    }
}