using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0020Tests
    {
        [DataTestMethod]
        [DataRow("()", true)]
        [DataRow("]", false)]
        public void IsValidTest(string s, bool expected)
        {
            var leetCode = new LeetCode0020();
            var output = leetCode.IsValid(s);
            Assert.AreEqual(expected, output);
        }
    }
}