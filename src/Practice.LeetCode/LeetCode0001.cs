using System.Collections.Generic;

namespace Practice.LeetCode
{
    public class LeetCode0001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>(nums.Length);
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (map.TryGetValue(num, out var index))
                {
                    return new int[] { index, i };
                }
                else
                {
                    map[target - num] = i;
                }
            }

            return new int[0];
        }
    }
}