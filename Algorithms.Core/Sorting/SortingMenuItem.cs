using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Sorting
{
    public static class SortingMenuItem
    {
        public static readonly Lazy<List<SortAlgorithm>> SortAlgorithms = new Lazy<List<SortAlgorithm>>(GetSortingAlgorithms);

        private static List<SortAlgorithm> GetSortingAlgorithms()
        {
            List<SortAlgorithm> algorithms = new List<SortAlgorithm>
            {
                new Bogosort.Bogosort(),
                new BubbleSort.BubbleSort()
            };
            return algorithms;
        }
    }
}
