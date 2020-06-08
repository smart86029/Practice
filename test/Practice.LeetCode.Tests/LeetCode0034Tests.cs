using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0034Tests
    {
        [DataTestMethod]
        [DataRow(new[] { 5, 7, 7, 8, 8, 10 }, 8, new[] { 3, 4 })]
        [DataRow(new[] { 5, 7, 7, 8, 8, 10 }, 6, new[] { -1, -1 })]
        [DataRow(new[] { 1, 4 }, 4, new[] { 1, 1 })]
        public void SearchRangeTest(int[] nums, int target, int[] expected)
        {
            var leetCode = new LeetCode0034();
            var output = leetCode.SearchRange(nums, target);
            Console.WriteLine(output[0]);
            Console.WriteLine(output[1]);
            CollectionAssert.AreEqual(expected, output);
        }
    }
}