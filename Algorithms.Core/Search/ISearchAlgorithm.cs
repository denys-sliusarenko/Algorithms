using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Search
{
    public interface ISearchAlgorithm
    {
        string Name { get; }
        int Search(int[] array, int key);
    }
}
