using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Practice.LeetCode.LeetCode0019;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0019Tests
    {
        [DataTestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 1, 2, 3, 5 })]
        public void RemoveNthFromEndTest(int[] nums, int n, int[] expected)
        {
            var head = ToListNode(nums);
            var leetCode = new LeetCode0019();
            var output = leetCode.RemoveNthFromEnd(head, n);
            CollectionAssert.AreEqual(expected, FromListNode(output));

            ListNode ToListNode(int[] nums)
            {
                var result = default(ListNode);
                var temp = default(ListNode);
                foreach (var num in nums)
                {
                    var node = new ListNode(num);
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