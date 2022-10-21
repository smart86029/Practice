namespace Practice.LeetCode.Algorithms;

public class LeetCode0033
{
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var middle = left + (right - left) / 2;

            if (nums[middle] == target)
            {
                return middle;
            }
            else if (nums[left] <= target && nums[middle] > target)
            {
                right = middle - 1;
            }
            else if (nums[left] > nums[middle] &&
                (nums[left] <= target || nums[middle] > target))
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return -1;
    }
}
