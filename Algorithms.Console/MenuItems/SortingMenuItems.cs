using Algorithms.Core.Sorting;
using Algorithms.Core.Sorting.Bogosort;
using Algorithms.Core.Sorting.BubbleSort;
using System;
using System.Collections.Generic;

namespace Algorithms.ConsoleApp.MenuItems
{
    public class SortingMenuItems: IMenuItem
    {
        public static readonly Lazy<List<ISortAlgorithm>> SortAlgorithms = new Lazy<List<ISortAlgorithm>>(GetSortingAlgorithms);
        public string Name => "Sorting Algorithms";

        private static List<ISortAlgorithm> GetSortingAlgorithms()
        {
            List<ISortAlgorithm> algorithms = new List<ISortAlgorithm>
            {
                new Bogosort(),
                new BubbleSort()
            };
            return algorithms;
        }
       
    }

}
