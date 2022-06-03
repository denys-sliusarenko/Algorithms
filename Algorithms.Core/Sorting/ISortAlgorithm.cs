using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Sorting
{
    public interface ISortAlgorithm
    {
        string Name { get; }
        int[] Sort(int[] array);
    }
}
