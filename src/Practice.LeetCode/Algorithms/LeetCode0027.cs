namespace Practice.LeetCode.Algorithms;

public class LeetCode0027
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums is null || nums.Length == 0)
        {
            return 0;
        }

        var last = nums.Length - 1;
        for (var i = 0; i < last + 1; i++)
        {
            if (nums[i] == val)
            {
                nums[i] = nums[last];
                nums[last] = val;
                last--;
                i--;
            }
        }

        return last + 1;
    }
}
