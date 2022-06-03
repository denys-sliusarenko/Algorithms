using Algorithms.ConsoleApp.Services;
using Algorithms.Core.Sorting;
using System;

namespace Algorithms.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < SortingMenuItem<int>.SortAlgorithms.Value.Count; i++)
                {
                    Console.WriteLine(string.Concat(i, ".", SortingMenuItem<int>.SortAlgorithms.Value[i].Name));
                }

                Console.Write("Select algorithm sort 0-{0}: ", SortingMenuItem<int>.SortAlgorithms.Value.Count - 1);
                var selectedAlgorithm = Convert.ToInt32(Console.ReadLine().Trim());
                Console.WriteLine(selectedAlgorithm);

              //  int type = InputArrayService.InputTypeArray();
               // if(type==1)
              //  {
                    int[] array = InputArrayService.InputGenerateIntArray();
                    var sort = SortingMenuItem<int>.SortAlgorithms.Value[selectedAlgorithm];

                //}
                //else if (type == 2)
                //{
                //    double[] array = InputArrayService.InputGenerateDoubleArray ();

                //}

              

                Console.WriteLine("Generated array: ");
                OutputService.OutputArrayLine(array);
                array = sort.Sort(array);

                Console.WriteLine("Sorting...");

                Console.WriteLine("Sorted array: ");
                OutputService.OutputArrayLine(array);
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
