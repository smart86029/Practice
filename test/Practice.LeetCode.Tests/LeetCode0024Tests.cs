using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Practice.LeetCode.LeetCode0024;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0024Tests
    {
        [DataTestMethod]
        [DataRow(new[] { 1, 2, 3, 4 }, new[] { 2, 1, 4, 3 })]
        public void SwapPairsTest(int[] head, int[] expected)
        {
            var leetCode = new LeetCode0024();
            var output = leetCode.SwapPairs(ToListNode(head));
            CollectionAssert.AreEqual(expected, FromListNode(output));

            ListNode ToListNode(int[] nums)
            {
                var result = default(ListNode);
                var temp = default(ListNode);
                foreach (var i in nums)
                {
                    var node = new ListNode(i);
                    if (temp != default)
                        temp.next = node;
                    else
                        result = node;

                    temp = node;
                }

                return result;
            }

            int[] FromListNode(ListNode node)
            {
                var nums = new List<int>();
                var temp = node;
                while (temp != default)
                {
                    nums.Add(temp.val);
                    temp = temp.next;
                }

                return nums.ToArray();
            }
        }
    }
}