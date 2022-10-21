namespace Practice.LeetCode.Algorithms;

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
                return new[] { index, i };
            }
            else
            {
                map[target - num] = i;
            }
        }

        return Array.Empty<int>();
    }
}
