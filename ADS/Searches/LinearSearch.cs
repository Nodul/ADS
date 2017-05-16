using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Searches
{
    // Simply iterate through all elements till you find the one you want. If you checked all, return null or -1
    // Also known as sequential search

    public static class LinearSearch
    {
        /// <summary>
        /// Returns index of the target element in the input array. Returns -1 if not found
        /// </summary>
        /// <param name="input"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int FindIndexOf(int[] input, int target)
        {
            if (input == null) throw new ArgumentNullException("Input array reference cannot be null");
            if (input.Length < 1) throw new ArgumentException("Length of input array cannot be shorter than 1");

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == target) return i;
            }
            return -1; // target not found in input collection
        }
    }
}
