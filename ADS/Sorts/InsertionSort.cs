using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ADS.Sorts
{
    // The idea is to, starting from the second element, at each iteration move the current key to it's proper place in the preceding, partly sorted array and
    // move existing elements if necessary.

    public static class InsertionSort
    {
        public static int[] SortAsc(int[] input)
        {
            if (input.Length < 1) throw new ArgumentException("Array is too short to sort");
            if (input.Length == 1) return input; 

            for(int i = 1; i < input.Length; i++)
            {
                var key = input[i];
                int j = i - 1; // precceding slot

                while (j >= 0 && input[j] > key) // j >= 0 because we have a zero-based index
                {
                    input[j + 1] = input[j];
                    j = j - 1;
                }

                input[j + 1] = key;
                Debug.WriteLine("i = "+i);
            }

            return input;
        }
        public static int[] SortDesc(int[] input)
        {
            if (input.Length < 1) throw new ArgumentException("Array is too short to sort");
            if (input.Length == 1) return input;

            for (int i = 1; i < input.Length; i++)
            {
                var key = input[i];
                int j = i - 1; // precceding slot

                while (j >= 0 && input[j] < key) //  input[j] < key because we want the results to be decreasing
                {
                    input[j + 1] = input[j];
                    j = j - 1;
                }

                input[j + 1] = key;
                Debug.WriteLine("i = " + i);
            }

            return input;
        }

        

    }
}
