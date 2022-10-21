namespace Practice.LeetCode.Algorithms;

public class LeetCode0219
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if (nums is null || nums.Length <= 1)
        {
            return false;
        }

        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var key = nums[i];
            if (map.TryGetValue(key, out var left) && i - left <= k)
            {
                return true;
            }
            else
            {
                map[key] = i;
            }
        }

        return false;
    }
}
