using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core
{
    public static class ArrayExtension
    {
        public static bool IsSorted(this int[] arr, int n)
        {
            if (n == 1 || n == 0)
                return true;//sorted

            if (arr[n - 1] < arr[n - 2])
                return false;//unsorted

            return IsSorted(arr, n - 1);
        }
    }
}