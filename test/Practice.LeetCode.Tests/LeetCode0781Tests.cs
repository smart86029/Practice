using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0781Tests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 1, 2 }, 5)]
        [DataRow(new int[] { 10, 10, 10 }, 11)]
        [DataRow(new int[] { }, 0)]
        [DataRow(new int[] { 0, 0, 1, 1, 1 }, 6)]
        public void NumRabbitsTest(int[] answers, int expected)
        {
            var leetCode = new LeetCode0781();
            var output = leetCode.NumRabbits(answers);
            Assert.AreEqual(expected, output);
        }
    }
}