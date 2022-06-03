using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Sorting
{
    public static class SortingMenuItem
    {
        public static readonly Lazy<List<ISortAlgorithm>> SortAlgorithms = new Lazy<List<ISortAlgorithm>>(GetSortingAlgorithms);

        private static List<ISortAlgorithm> GetSortingAlgorithms()
        {
            List<ISortAlgorithm> algorithms = new List<ISortAlgorithm>
            {
                new Bogosort.Bogosort(),
                new BubbleSort.BubbleSort()
            };
            return algorithms;
        }
       
    }

}
