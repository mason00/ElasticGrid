using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElasticGrid;

namespace Tests
{
    [TestClass]
    public class PositiveDivisorsTests
    {
        [TestMethod]
        public void OutputPositiveDivisor()
        {
            var output = PositiveDivisors.OutputPositiveDivisor(60);
            CollectionAssert.AreEqual(output, new int[] { 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 });

            output = PositiveDivisors.OutputPositiveDivisor(42);
            CollectionAssert.AreEqual(output, new int[] {1, 2, 3, 6, 7, 14, 21, 42});
        }
    }
}
