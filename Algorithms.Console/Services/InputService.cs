using Algorithms.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.ConsoleApp.Services
{
    internal static class InputService<T> where T : struct, IComparable<T>
    {
        private static int InputCountArray()
        {
            Console.Write("Enter the number of array elements: ");
            var amount = Convert.ToInt32(Console.ReadLine().Trim());
            if (amount <= 0)
            {
                throw new ArgumentException("Number can't be less or equals 0");
            }
            return amount;
        }

        public static double[] InputGenerateDoubleArray()
        {
            return ArrayGenerator.GenerateDoubleArray(InputCountArray());
        }

        public static int[] InputGenerateIntArray()
        {
            return ArrayGenerator.GenerateIntArray(InputCountArray());
        }
    }
}
