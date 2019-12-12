using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0015Tests
    {
        [TestMethod]
        public void TwoSumTest()
        {
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };
            var expected = new List<IList<int>>
            {
                new List<int> { -1, -1, 2 },
                new List<int> { -1, 0, 1 },
            };

            var leetCode = new LeetCode0015();
            var output = leetCode.ThreeSum(nums);
            Assert.AreEqual(expected.Count, output.Count);
            for (var i = 0; i < expected.Count; i++)
                CollectionAssert.AreEqual(expected[i].ToList(), output[i].ToList());
        }
    }
}