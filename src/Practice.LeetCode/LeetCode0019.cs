using System.Collections.Generic;

namespace Practice.LeetCode
{
    public class LeetCode0019
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var nodes = new List<ListNode>();
            var curent = head;
            while (curent != default)
            {
                nodes.Add(curent);
                curent = curent.next;
            }

            var remove = nodes.Count - n;
            if (remove - 1 >= 0)
                nodes[remove - 1].next = nodes[remove].next;
            else
                return nodes[remove].next;

            return nodes[0];
        }

        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
            }
        }
    }
}