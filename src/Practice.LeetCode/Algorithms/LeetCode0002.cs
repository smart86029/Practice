namespace Practice.LeetCode.Algorithms;

public class LeetCode0002
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var result = default(ListNode);
        var last = default(ListNode);
        var temp1 = l1;
        var temp2 = l2;
        var carry = 0;
        while (temp1 is not null || temp2 is not null || carry > 0)
        {
            var sum = carry;
            if (temp1 is not null)
            {
                sum += temp1.val;
                temp1 = temp1.next;
            }
            if (temp2 is not null)
            {
                sum += temp2.val;
                temp2 = temp2.next;
            }

            var current = new ListNode(sum % 10);
            carry = sum / 10;
            if (last is not null)
            {
                last.next = current;
            }

            last = current;
            result ??= current;
        }

        return result;
    }
}
