namespace Practice.LeetCode
{
    public class LeetCode0034
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var result = new[] { -1, -1 };
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;

                if (nums[middle] == target && (middle == 0 || nums[middle - 1] < target))
                {
                    result[0] = middle;
                    break;
                }
                else if (nums[right] >= target && nums[middle] < target)
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            right = nums.Length - 1;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;

                if (nums[middle] == target && (middle == nums.Length - 1 || nums[middle + 1] > target))
                {
                    result[1] = middle;
                    break;
                }
                else if (nums[left] <= target && nums[middle] > target)
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return result;
        }
    }
}