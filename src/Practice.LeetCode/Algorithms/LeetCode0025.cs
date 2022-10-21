namespace Practice.LeetCode.Algorithms;

public class LeetCode0025
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (head is null || k <= 1)
        {
            return head;
        }

        var previous = new ListNode(0)
        {
            next = head
        };

        var start = head;
        var end = GetKthNode(start, k);
        if (end is null)
        {
            return head;
        }
        else
        {
            head = end;
        }

        while (start is not null && end is not null)
        {
            Reverse(start, end);
            previous.next = end;
            previous = start;
            start = start.next;
            end = GetKthNode(start, k);
        }

        return head;

        ListNode GetKthNode(ListNode start, int k)
        {
            while (start is not null && k > 1)
            {
                start = start.next;
                k--;
            }

            return start;
        }

        void Reverse(ListNode start, ListNode end)
        {
            var current = start;
            var previous = default(ListNode);

            while (current != end)
            {
                var temp = current.next;
                current.next = previous;
                previous = current;
                current = temp;
            }

            start.next = end.next;
            current.next = previous;
        }
    }
}
