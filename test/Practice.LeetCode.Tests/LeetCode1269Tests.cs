using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode1269Tests
    {
        [DataTestMethod]
        [DataRow(3, 2, 4)]
        public void NumWays(int steps, int arrLen, int expected)
        {
            var leetCode = new LeetCode1269();
            var output = leetCode.NumWays(steps, arrLen);
            Assert.AreEqual(expected, output);
        }
    }
}
