using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Practice.LeetCode.LeetCode0025;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0025Tests
    {
        [DataTestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 2, 1, 4, 3, 5 })]
        [DataRow(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 3, 2, 1, 4, 5 })]
        public void ReverseKGroupTest(int[] head, int k, int[] expected)
        {
            var leetCode = new LeetCode0025();
            var output = leetCode.ReverseKGroup(ToListNode(head), k);
            var a = FromListNode(output);
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