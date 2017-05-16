using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ADS.Sorts;
using System.Diagnostics;

namespace ADS.Tests.Sorts
{
    [TestClass]
    public class InsertionSortAscTest
    {
        [TestMethod]
        public void InsertionSortAscIntArray_Valid_True()
        {
            // Assign
            int[] input = { 1, 100, 2, 10, 3 };
            int[] expected = { 1, 2, 3, 10, 100 };
            // Act
            input = InsertionSort.SortAsc(input);

            //foreach (var item in input)
            //{
            //   Trace.WriteLine(item);
            //   
            //}
            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
        [TestMethod]
        public void InsertionSortAscIntArray_TooShort_True()
        {
            // Assign
            int[] input = { 1};
            int[] expected = { 1};
            // Act
            input = InsertionSort.SortAsc(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void InsertionSortAscIntArray_LengthIs2_True()
        {
            // Assign
            int[] input = { 100, 1 };
            int[] expected = { 1, 100 };
            // Act
            input = InsertionSort.SortAsc(input);

            foreach (var item in input)
            {
                Trace.WriteLine(item);
                //Debug.WriteLine(item);
            }

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void InsertionSortAscIntArray_AllNegatives_True()
        {
            // Assign
            int[] input = { -1, -100, -2, -10, -3 };
            int[] expected = { -100,-10,-3,-2,-1};
            // Act
            input = InsertionSort.SortAsc(input);

            //foreach (var item in input)
            //{
            //   Trace.WriteLine(item);
            //   
            //}
            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void InsertionSortAscIntArray_MixedInNegatives_True()
        {
            // Assign
            int[] input = { -1, 100, 2, -10, -3 };
            int[] expected = { -10, -3, -1, 2, 100 };
            // Act
            input = InsertionSort.SortAsc(input);

            //foreach (var item in input)
            //{
            //   Trace.WriteLine(item);
            //   
            //}
            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InsertionSortAscIntArray_EmptyArray_ArgumentException()
        {
            // Assign
            int[] input = new int[0];

            // Act
            input = InsertionSort.SortAsc(input);

            // Assert
        }

    }

}
