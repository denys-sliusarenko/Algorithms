using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Sorting
{
    public interface ISortAlgorithm<T> where T : IComparable<T>
    {
        string Name { get; }
        T[] Sort(T[] array);
    }
}
