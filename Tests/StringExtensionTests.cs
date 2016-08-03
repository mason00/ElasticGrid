using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElasticGrid;

namespace Tests
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void IsNull()
        {
            string s = null;
            Assert.IsTrue(s.IsNullOrEmpty());
        }

        [TestMethod]
        public void IsNotEmpty()
        {
            Assert.IsFalse("a".IsNullOrEmpty());
        }

        [TestMethod]
        public void IsEmpty()
        {
            Assert.IsTrue("".IsNullOrEmpty());
        }

        [TestMethod]
        public void IsLiteralNull()
        {
            Assert.IsFalse("null".IsNullOrEmpty());
        }
    }
}
