using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Practice.LeetCode.LeetCode0023;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0023Tests
    {
        [TestMethod]
        public void MergeKListsTest()
        {
            var lists = new[]
            {
                ToListNode(new[] { 1, 4, 5 }),
                ToListNode(new[] { 1, 3, 4 }),
                ToListNode(new[] { 2, 6 }),
            };
            var expected = new[] { 1, 1, 2, 3, 4, 4, 5, 6 };
            var leetCode = new LeetCode0023();
            var output = leetCode.MergeKLists(lists);
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