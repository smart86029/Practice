namespace Practice.LeetCode.Algorithms;

public class LeetCode0024
{
    public ListNode SwapPairs(ListNode head)
    {
        var result = new ListNode(0);
        var last = result;
        var current = head;

        while (current is not null)
        {
            var next = current.next;
            if (next is not null)
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
}
