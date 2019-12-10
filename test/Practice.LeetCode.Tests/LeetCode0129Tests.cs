using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Practice.LeetCode.LeetCode0129;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0129Tests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3 }, 25)]
        [DataRow(new int[] { }, 0)]
        public void SumNumbersTest(int[] nums, int expected)
        {
            var leetCode = new LeetCode0129();
            var output = leetCode.SumNumbers(ToTreeNode(nums));
            Assert.AreEqual(expected, output);

            TreeNode ToTreeNode(int[] nums)
            {
                if (nums.Length == 0)
                    return default;

                var count = nums.Length;
                var nodes = new TreeNode[count];

                for (var i = 0; i < count; i++)
                {
                    var leftIndex = i * 2 + 1;
                    var rightIndex = leftIndex + 1;

                    if (nodes[i] == default)
                        nodes[i] = new TreeNode(0);

                    nodes[i].val = nums[i];
                    if (leftIndex < count)
                    {
                        nodes[leftIndex] = new TreeNode(0);
                        nodes[i].left = nodes[leftIndex];
                    }
                    if (rightIndex < count)
                    {
                        nodes[rightIndex] = new TreeNode(0);
                        nodes[i].right = nodes[rightIndex];
                    }
                }

                return nodes[0];
            }
        }
    }
}