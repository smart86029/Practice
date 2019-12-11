using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Practice.LeetCode.LeetCode1110;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode1110Tests
    {
        [TestMethod]
        public void DelNodesTest()
        {
            var nums = new int?[] { 1, 2, 3, 4, 5, 6, 7 };
            var toDelete = new int[] { 3, 5 };
            var expected = new int?[][]
            {
                new int?[] { 1, 2, default, 4 },
                new int?[] { 6 },
                new int?[] { 7 },
            };
            var leetCode = new LeetCode1110();
            var output = leetCode.DelNodes(ToTreeNode(nums), toDelete);
            var actual = output.Select(x => FromTreeNode(x)).ToArray();

            Assert.AreEqual(expected.Length, actual.Length);
            for (var i = 0; i < expected.Length; i++)
                CollectionAssert.AreEqual(expected[i], actual[i]);

            TreeNode ToTreeNode(int?[] nums)
            {
                if (nums.Length == 0)
                    return default;

                var count = nums.Length;
                var nodes = new TreeNode[count];
                var parents = new Queue<TreeNode>();

                for (var i = 0; i < count; i++)
                {
                    if (!nums[i].HasValue)
                        continue;

                    nodes[i] = new TreeNode(nums[i].Value);
                    parents.Enqueue(nodes[i]);
                    if (i == 0)
                        continue;

                    var parent = parents.Peek();
                    if (parent.left == default)
                    {
                        parent.left = nodes[i];
                    }
                    else
                    {
                        parent.right = nodes[i];
                        parents.Dequeue();
                    }
                }

                return nodes[0];
            }

            int?[] FromTreeNode(TreeNode node)
            {
                var nums = new List<int?>();
                var nodes = new Queue<TreeNode>();
                nodes.Enqueue(node);

                while (nodes.Any())
                {
                    var current = nodes.Dequeue();
                    nums.Add(current?.val);
                    if (current == default)
                        continue;

                    nodes.Enqueue(current.left);
                    nodes.Enqueue(current.right);
                }

                var lastIndex = nums.FindLastIndex(x => x.HasValue);

                return nums.Take(lastIndex + 1).ToArray();
            }
        }
    }
}