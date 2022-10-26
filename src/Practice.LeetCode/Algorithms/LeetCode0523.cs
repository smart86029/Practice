namespace Practice.LeetCode.Algorithms;

public class LeetCode0523
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        var sum = 0;
        var map = new Dictionary<int, int>
        {
            [0] = -1,
        };

        for (var i = 0; i < nums.Length; i++)
        {
            sum = (sum + nums[i]) % k;

            if (!map.TryGetValue(sum, out var index))
            {
                map.Add(sum, i);
            }
            else if (i - index >= 2)
            {
                return true;
            }
        }

        return false;
    }
}
