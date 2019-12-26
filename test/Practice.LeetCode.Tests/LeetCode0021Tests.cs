using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Practice.LeetCode.LeetCode0021;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0021Tests
    {
        [DataTestMethod]
        [DataRow(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
        public void MergeTwoListsTest(int[] num1, int[] num2, int[] expected)
        {
            var l1 = ToListNode(num1);
            var l2 = ToListNode(num2);
            var leetCode = new LeetCode0021();
            var output = leetCode.MergeTwoLists(l1, l2);
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