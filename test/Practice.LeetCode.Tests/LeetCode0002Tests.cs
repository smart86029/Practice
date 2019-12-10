using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Practice.LeetCode.LeetCode0002;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0002Tests
    {
        [DataTestMethod]
        [DataRow(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
        [DataRow(new int[] { 5 }, new int[] { 5 }, new int[] { 0, 1 })]
        public void AddTwoNumbersTest(int[] nums1, int[] nums2, int[] expected)
        {
            var l1 = ToListNode(nums1);
            var l2 = ToListNode(nums2);
            var leetCode = new LeetCode0002();
            var output = leetCode.AddTwoNumbers(l1, l2);
            var actual = FromListNode(output);
            CollectionAssert.AreEqual(expected, actual);

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