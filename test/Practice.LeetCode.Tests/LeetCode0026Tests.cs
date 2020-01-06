using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0026Tests
    {
        [DataTestMethod]
        [DataRow(new[] { 1, 1, 2 }, 2)]
        [DataRow(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        public void RemoveDuplicatesTest(int[] nums, int expected)
        {
            var leetCode = new LeetCode0026();
            var output = leetCode.RemoveDuplicates(nums);
            Assert.AreEqual(expected, output);
        }
    }
}