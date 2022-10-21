namespace Practice.LeetCode.Algorithms;

public class LeetCode0023
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists is null || lists.Length == 0)
        {
            return default;
        }

        return Divide(0, lists.Length - 1);

        ListNode Divide(int start, int end)
        {
            if (start == end)
            {
                return lists[start];
            }

            if (end - start == 1)
            {
                return Merge(lists[start], lists[end]);
            }

            var mid = (start + end) / 2;
            var left = Divide(start, mid);
            var right = Divide(mid + 1, end);

            return Merge(left, right);
        }

        ListNode Merge(ListNode l1, ListNode l2)
        {
            var head = new ListNode(0);
            var current = head;

            while (l1 is not null && l2 is not null)
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

            if (l1 is not null)
            {
                current.next = l1;
            }

            if (l2 is not null)
            {
                current.next = l2;
            }

            return head.next;
        }
    }
}
