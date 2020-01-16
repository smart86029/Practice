using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0031Tests
    {
        [DataTestMethod]
        [DataRow(new[] { 1, 2, 3 }, new[] { 1, 3, 2 })]
        [DataRow(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
        [DataRow(new[] { 1, 1, 5 }, new[] { 1, 5, 1 })]
        public void NextPermutationTest(int[] nums, int[] expected)
        {
            var leetCode = new LeetCode0031();
            leetCode.NextPermutation(nums);
            CollectionAssert.AreEqual(expected, nums);
        }
    }
}