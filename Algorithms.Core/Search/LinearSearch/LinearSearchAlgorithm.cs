using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Search.LinearSearch
{
    public class LinearSearchAlgorithm: ISearchAlgorithm
    {
        public string Name => "Linear search";

        public int Search(int[] array, int key)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i].Equals(key))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
