using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0322Tests
    {
        [DataTestMethod]
        [DataRow(new[] { 1, 2, 5 }, 11, 3)]
        [DataRow(new[] { 2 }, 3, -1)]
        public void CoinChangeTest(int[] coins, int amount, int expected)
        {
            var leetCode = new LeetCode0322();
            var output = leetCode.CoinChange(coins, amount);
            Assert.AreEqual(expected, output);
        }
    }
}