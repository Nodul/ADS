using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ADS.Sorts;
using System.Diagnostics;

namespace ADS.Tests.Sorts
{
    [TestClass]
    public class InsertionSortDescTest
    {
        [TestMethod]
        public void InsertionSortDescIntArray_Valid_True()
        {
            // Assign
            int[] input = { 1, 100, 2, 10, 3 };
            int[] expected = { 100, 10, 3, 2, 1 };
            // Act
            input = InsertionSort.SortDesc(input);

            //foreach (var item in input)
            //{
            //   Trace.WriteLine(item);
            //   
            //}
            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
        [TestMethod]
        public void InsertionSortDescIntArray_TooShort_True()
        {
            // Assign
            int[] input = { 1 };
            int[] expected = { 1 };
            // Act
            input = InsertionSort.SortDesc(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void InsertionSortDescIntArray_LengthIs2_True()
        {
            // Assign
            int[] input = { 1, 100 };
            int[] expected = { 100, 1 };
            // Act
            input = InsertionSort.SortDesc(input);

            foreach (var item in input)
            {
                Trace.WriteLine(item);
                //Debug.WriteLine(item);
            }

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void InsertionSortDescIntArray_AllNegatives_True()
        {
            // Assign
            int[] input = { -1, -100, -2, -10, -3 };
            int[] expected = { -1, -2, -3, -10, -100 };
            // Act
            input = InsertionSort.SortDesc(input);

            //foreach (var item in input)
            //{
            //   Trace.WriteLine(item);
            //   
            //}
            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void InsertionSortDescIntArray_MixedInNegatives_True()
        {
            // Assign
            int[] input = { -1, 100, 2, -10, -3 };
            int[] expected = { 100, 2, -1, -3, -10 };
            // Act
            input = InsertionSort.SortDesc(input);

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
        public void InsertionSortDescIntArray_EmptyArray_ArgumentException()
        {
            // Assign
            int[] input = new int[0];

            // Act
            input = InsertionSort.SortDesc(input);

            // Assert
        }

    }
}
