using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0016Tests
    {
        [DataTestMethod]
        [DataRow(new int[] { -1, 2, 1, -4 }, 1, 2)]
        [DataRow(new int[] { 1, 1, -1, -1, 3 }, -1, -1)]
        public void ThreeSumClosestTest(int[] nums, int target, int expected)
        {
            var leetCode = new LeetCode0016();
            var output = leetCode.ThreeSumClosest(nums, target);
            Assert.AreEqual(expected, output);
        }
    }
}