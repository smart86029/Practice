using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0009Tests
    {
        [DataTestMethod]
        [DataRow(121, true)]
        [DataRow(-121, false)]
        [DataRow(10, false)]
        public void ConvertTest(int x, bool expected)
        {
            var leetCode = new LeetCode0009();
            var output = leetCode.IsPalindrome(x);
            Assert.AreEqual(expected, output);
        }
    }
}