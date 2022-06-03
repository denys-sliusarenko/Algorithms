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
                SortAlgorithm sort = new Bogosort();
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
