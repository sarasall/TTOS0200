using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };      
        double expected;
        double actual;

        [TestMethod()]
        public void SumTest()
        {
            expected = 25.60;// Arrange
            actual = ArrayCalcs.Sum(array); // Actual
            Assert.AreEqual(expected, actual); // Assert
        }

        [TestMethod()]
        public void AverageTest()
        {
            expected = 3.66;// Arrange
            actual = ArrayCalcs.Average(array); // Actual
            Assert.AreEqual(expected, actual); // Assert
        }

        [TestMethod()]
        public void MinTest()
        {
            expected = -4.50; // Arrange
            actual = ArrayCalcs.Min(array); // Actual
            Assert.AreEqual(expected, actual); // Assert
        }

        [TestMethod()]
        public void MaxTest()
        {
            expected = 12.00;// Arrange
            actual = ArrayCalcs.Max(array); // Actual
            Assert.AreEqual(expected, actual); // Assert
        }
    }
}