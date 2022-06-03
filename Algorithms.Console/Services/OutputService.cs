using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.ConsoleApp.Services
{
    internal class OutputService
    {
        public static void OutputArrayLine(double[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
