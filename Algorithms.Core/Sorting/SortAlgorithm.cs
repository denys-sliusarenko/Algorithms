using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Sorting
{
    public abstract class SortAlgorithm
    {
        protected abstract string Name { get; }
        public abstract int[] Sort(int[] a);

        public int[] GenerateArray()
        {
            Console.WriteLine(Name);
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
                array[i] = random.Next(100)- random.Next(100);
            }

            return array;
        }

        public void OutputArray(int[] array)
        {
            Console.WriteLine(String.Join(", ", array));
        }
    }
}
