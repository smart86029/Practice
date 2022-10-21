namespace Practice.LeetCode.Algorithms;

public class LeetCode0035
{
    public int SearchInsert(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var middle = left + (right - left) / 2;

            if (nums[middle] >= target)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return left;
    }
}
