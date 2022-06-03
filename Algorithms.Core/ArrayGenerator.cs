using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core
{
    public class ArrayGenerator
    {
        public static int[] GenerateIntArray(int count)
        {
            var array = new int[count];
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                array[i] = random.Next(100) - random.Next(100);
            }
            return array;
        }

        public static double[] GenerateDoubleArray(int count)
        {
            int maximum = 100;
            int minimum = -100;
            var array = new double[count];
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                array[i] = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 1);
            }
            return array;
        }
    }
}
