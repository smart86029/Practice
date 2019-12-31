namespace Practice.LeetCode
{
    public class LeetCode0024
    {
        public ListNode SwapPairs(ListNode head)
        {
            var result = new ListNode(0);
            var last = result;
            var current = head;

            while (current != default)
            {
                var next = current.next;
                if (next != default)
                {
                    current.next = next.next;
                    next.next = current;
                    last.next = next;
                    last = current;
                    current = current.next;
                }
                else
                {
                    last.next = current;
                    current = next;
                }
            }

            return result.next;
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