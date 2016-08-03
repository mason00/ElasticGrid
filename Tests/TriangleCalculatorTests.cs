using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElasticGrid;

namespace Tests
{
    [TestClass]
    public class TriangleCalculatorTests
    {
        [TestMethod]
        public void Sides()
        {
            Assert.AreEqual(6, TriangleCalculator.Calculate(3, 4, 5));
        }

        [TestMethod]
        public void RightAngle()
        {
            Assert.AreEqual(12, TriangleCalculator.CalculateRightAngleTriangle(6, 4));
        }

        //Use NUnit TestCase attribute to add more input combination, MS test doesn't support it
        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void Nagitive()
        {
            TriangleCalculator.Calculate(3, -4, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void NagitiveRightAngle()
        {
            TriangleCalculator.CalculateRightAngleTriangle(-6, -4);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void InvalidTriangle()
        {
            TriangleCalculator.Calculate(4, 5, 1);
        }
    }
}
