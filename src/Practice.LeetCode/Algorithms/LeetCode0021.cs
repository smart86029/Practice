namespace Practice.LeetCode.Algorithms;

public class LeetCode0021
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
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
