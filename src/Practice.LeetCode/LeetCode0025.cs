namespace Practice.LeetCode
{
    public class LeetCode0025
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == default || k <= 1)
                return head;

            var previous = new ListNode(0);
            previous.next = head;

            var start = head;
            var end = GetKthNode(start, k);

            if (end == default)
                return head;
            else
                head = end;

            while (start != default && end != default)
            {
                Reverse(start, end);
                previous.next = end;
                previous = start;
                start = start.next;
                end = GetKthNode(start, k);
            }

            return head;
        }

        private ListNode GetKthNode(ListNode start, int k)
        {
            while (start != default && k > 1)
            {
                start = start.next;
                k--;
            }

            return start;
        }

        private void Reverse(ListNode start, ListNode end)
        {
            var current = start;
            var previous = default(ListNode);
            var temp = default(ListNode);

            while (current != end)
            {
                temp = current.next;
                current.next = previous;
                previous = current;
                current = temp;
            }

            start.next = end.next;
            current.next = previous;
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