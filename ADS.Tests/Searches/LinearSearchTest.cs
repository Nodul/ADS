using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ADS.Searches;

namespace ADS.Tests.Searches
{
    [TestClass]
    public class LinearSearchTest
    {
        [TestMethod]
        public void LinearSearchFindIndexOfIntArray_Valid_True()
        {
            // Assign
            int[] input = {10,50,5,59,600,30,80,0 };
            int target = 600;
            int expected = 4; //5 element so 4 for a 0-based array
            // Act
            int result = LinearSearch.FindIndexOf(input, target);

            // Assert
            Assert.AreEqual(expected,result);

        }

        [TestMethod]
        public void LinearSearchFindIndexOfIntArray_ValidOnly1Element_True()
        {
            // Assign
            int[] input = { 10 };
            int target = 10;
            int expected = 0; 
            // Act
            int result = LinearSearch.FindIndexOf(input, target);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void LinearSearchFindIndexOfIntArray_ElementDoesntExist_Minus1()
        {
            // Assign
            int[] input = { 10, 50, 5, 59, 600, 30, 80, 0 };
            int target = -500;
            int expected = -1; 
            // Act
            int result = LinearSearch.FindIndexOf(input, target);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LinearSearchFindIndexOfIntArray_ArrayLengthLessThan1_ArgumentException()
        {
            int[] input = {};
            int target = 600;

            int result = LinearSearch.FindIndexOf(input, target);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LinearSearchFindIndexOfIntArray_NullInputArray_ArgumentException()
        {
            int[] input = null;
            int target = 600;

            int result = LinearSearch.FindIndexOf(input, target);
        }

    }
}
