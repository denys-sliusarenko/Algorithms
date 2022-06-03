using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Sorting
{
    public static class SortingMenuItem
    {
        public static readonly Lazy<List<ISortAlgorithm<double>>> SortAlgorithms = new Lazy<List<ISortAlgorithm<double>>>(GetSortingAlgorithms);

        private static List<ISortAlgorithm<double>>GetSortingAlgorithms()
        {
            List<ISortAlgorithm<double>> algorithms = new List<ISortAlgorithm<double>>
            {
                new Bogosort.Bogosort<double>(),
                new BubbleSort.BubbleSort<double>()
            };
            return algorithms;
        }
    }
}
