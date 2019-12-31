namespace Practice.LeetCode
{
    public class LeetCode0023
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == default || lists.Length == 0)
                return default;

            return Divide(0, lists.Length - 1);

            ListNode Divide(int start, int end)
            {
                if (start == end)
                    return lists[start];

                if (end - start == 1)
                    return Merge(lists[start], lists[end]);

                var mid = (start + end) / 2;
                ListNode left = Divide(start, mid);
                ListNode right = Divide(mid + 1, end);

                return Merge(left, right);
            }

            ListNode Merge(ListNode l1, ListNode l2)
            {
                var head = new ListNode(0);
                var current = head;

                while (l1 != default && l2 != default)
                {
                    if (l1.val < l2.val)
                    {
                        current.next = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        current.next = l2;
                        l2 = l2.next;
                    }

                    current = current.next;
                }

                if (l1 != default)
                    current.next = l1;
                if (l2 != default)
                    current.next = l2;

                return head.next;
            }
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