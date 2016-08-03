using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElasticGrid;

namespace Tests
{
    [TestClass]
    public class MostCommonSequenceTests
    {
        [TestMethod]
        public void OutputMostCommonSequenece()
        {
            var input = new int[] { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 };
            CollectionAssert.AreEqual(new int[] { 5, 4 }, MostCommonSequence.Output(input));

            input = new int[] { 1, 2, 3, 4, 5, 1, 6, 7 };
            CollectionAssert.AreEqual(new int[] { 1 }, MostCommonSequence.Output(input));

            input = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            CollectionAssert.AreEqual(input, MostCommonSequence.Output(input));
        }
    }
}
