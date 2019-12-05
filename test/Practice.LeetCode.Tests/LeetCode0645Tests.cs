using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0645Tests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 2, 4 }, new int[] { 2, 3 })]
        [DataRow(new int[] { 1, 1 }, new int[] { 1, 2 })]
        public void FindErrorNumsTest(int[] nums, int[] expected)
        {
            var leetCode = new LeetCode0645();
            var output = leetCode.FindErrorNums(nums);
            CollectionAssert.AreEqual(expected, output);
        }
    }
}