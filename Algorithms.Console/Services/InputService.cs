using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.ConsoleApp.Services
{
    internal static class InputService
    {
        public static int[] GenerateArray()
        {
            Console.Write("Enter the number of array elements: ");
            var amount = Convert.ToInt32(Console.ReadLine().Trim());
            if (amount <= 0)
            {
                throw new ArgumentException("Number can't be less or equals 0");
            }
            var array = new int[amount];

            Random random = new Random();
            for (int i = 0; i < amount; i++)
            {
                array[i] = random.Next(100) - random.Next(100);
            }

            return array;
        }
    }
}
