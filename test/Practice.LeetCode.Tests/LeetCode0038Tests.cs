using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0038Tests
    {
        [DataTestMethod]
        [DataRow(1, "1")]
        [DataRow(4, "1211")]
        public void CountAndSayTest(int n, string expected)
        {
            var leetCode = new LeetCode0038();
            var output = leetCode.CountAndSay(n);
            Assert.AreEqual(expected, output);
        }
    }
}