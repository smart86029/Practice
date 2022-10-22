namespace Practice.LeetCode.Algorithms;

public class LeetCode0041
{
    public int FirstMissingPositive(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            while (nums[i] > 0 && nums[i] <= nums.Length && nums[i] != i + 1)
            {
                var num = nums[i];
                if (num == nums[num - 1])
                {
                    nums[i] = -1;
                    break;
                }

                (nums[i], nums[num - 1]) = (nums[num - 1], nums[i]);
            }
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
            {
                return i + 1;
            }
        }

        return nums.Length + 1;
    }
}
