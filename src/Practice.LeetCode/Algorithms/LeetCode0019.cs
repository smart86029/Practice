namespace Practice.LeetCode.Algorithms;

public class LeetCode0019
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var nodes = new List<ListNode>();
        var curent = head;
        while (curent is not null)
        {
            nodes.Add(curent);
            curent = curent.next;
        }

        var remove = nodes.Count - n;
        if (remove - 1 >= 0)
        {
            nodes[remove - 1].next = nodes[remove].next;
        }
        else
        {
            return nodes[remove].next;
        }

        return nodes[0];
    }
}
