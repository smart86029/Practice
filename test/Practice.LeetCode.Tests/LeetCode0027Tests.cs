using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0027Tests
    {
        [DataTestMethod]
        [DataRow(new[] { 3, 2, 2, 3 }, 3, 2)]
        [DataRow(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        public void RemoveElementTest(int[] nums, int val, int expected)
        {
            var leetCode = new LeetCode0027();
            var output = leetCode.RemoveElement(nums, val);
            Assert.AreEqual(expected, output);
        }
    }
}