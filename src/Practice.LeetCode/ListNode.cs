namespace Practice.LeetCode;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode FromArray(int[] nums)
    {
        var result = default(ListNode);
        var temp = default(ListNode);
        foreach (var i in nums)
        {
            var node = new ListNode(i);
            if (temp is not null)
            {
                temp.next = node;
            }
            else
            {
                result = node;
            }

            temp = node;
        }

        return result;
    }

    public int[] ToArray()
    {
        var nums = new List<int>();
        var temp = this;
        while (temp is not null)
        {
            nums.Add(temp.val);
            temp = temp.next;
        }

        return nums.ToArray();
    }
}
