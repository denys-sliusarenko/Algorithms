using Algorithms.Core.Sorting;
using Algorithms.Core.Sorting.Bogosort;
using System;

namespace Algorithms.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < SortingMenuItem.SortAlgorithms.Value.Count; i++)
                {
                    Console.WriteLine(string.Concat(i, ".", SortingMenuItem.SortAlgorithms.Value[i].Name));
                }

                Console.Write("Select algorithm sort 0-{0}: ", SortingMenuItem.SortAlgorithms.Value.Count - 1);
                var selectedAlgorithm = Convert.ToInt32(Console.ReadLine().Trim());
                Console.WriteLine(selectedAlgorithm);
                var sort = SortingMenuItem.SortAlgorithms.Value[selectedAlgorithm];

                int[] array = sort.GenerateArray();
                Console.WriteLine("Generated array: ");
                sort.OutputArray(array);
                array = sort.Sort(array);

                Console.WriteLine("Sorting...");

                Console.WriteLine("Sorted array: ");
                sort.OutputArray(array);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
