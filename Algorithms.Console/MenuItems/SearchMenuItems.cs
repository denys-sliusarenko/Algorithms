using Algorithms.Core.Search;
using Algorithms.Core.Search.BinarySearchAlgorithm;
using Algorithms.Core.Search.LinearSearch;
using System;
using System.Collections.Generic;

namespace Algorithms.ConsoleApp.MenuItems
{
    public class SearchMenuItems: IMenuItem
    {
        public static readonly Lazy<List<ISearchAlgorithm>> SearchAlgorithms = new Lazy<List<ISearchAlgorithm>>(GetSearchAlgorithms);

        public string Name => "Search Algorithms";

        private static List<ISearchAlgorithm> GetSearchAlgorithms()
        {
            List<ISearchAlgorithm> algorithms = new List<ISearchAlgorithm>
            {
                new LinearSearchAlgorithm(),
                new BinarySearchAlgorithm()
            };
            return algorithms;
        }
    }
}
