using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Search.BinarySearchAlgorithm
{
    public class BinarySearchAlgorithm : ISearchAlgorithm
    {
        public string Name => "Binary Search";

        public int Search(int[] array, int key)
        {
            if (!array.IsSorted(array.Length))
            {
                throw new Exception("Array is not sorted! This search method works only with sorted arrays.");
            }

            int result = BinarySearch(array, key, 0, array.Length - 1);
            return result;
        }

        //binary search method
        private static int BinarySearch(int[] array, int searchedValue, int first, int last)
        {

            if (first > last)
            {
                //didn't find element
                return -1;
            }

            //middle index sub array
            var middle = (first + last) / 2;

            //value middle array
            var middleValue = array[middle];

            if (middleValue == searchedValue)
            {
                return middle;
            }
            else
            {
                if (middleValue > searchedValue)
                {
                    //recursion call search left subarray
                    return BinarySearch(array, searchedValue, first, middle - 1);
                }
                else
                {
                    //recursion call search right subarray
                    return BinarySearch(array, searchedValue, middle + 1, last);
                }
            }
        }
    }
}
