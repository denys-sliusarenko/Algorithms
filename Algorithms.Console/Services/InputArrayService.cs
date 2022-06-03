using Algorithms.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.ConsoleApp.Services
{
    internal static class InputArrayService
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

        //public static int InputTypeArray()
        //{
        //    Console.WriteLine("Enter type elements: ");
        //    Console.WriteLine("1. int");
        //    Console.WriteLine("2. double");

        //    var type = Convert.ToInt32(Console.ReadLine().Trim());
        //    if (type <= 0 || type > 2)
        //    {
        //        throw new ArgumentException("Number can't be less or equals 0 and more than 2");
        //    }
        //    return type;
        //}

        //public static double[] InputGenerateDoubleArray()
        //{
        //    return ArrayGenerator.GenerateDoubleArray(InputCountArray());
        //}

        public static int[] InputGenerateIntArray()
        {
            return ArrayGenerator.GenerateIntArray(InputCountArray());
        }
    }
}
