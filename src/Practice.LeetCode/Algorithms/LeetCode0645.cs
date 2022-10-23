namespace Practice.LeetCode.Algorithms;

public class LeetCode0645
{
    public int[] FindErrorNums(int[] nums)
    {
        var records = new int[nums.Length + 1];
        var duplicated = 0;
        var sumXor = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            sumXor ^= nums[i] ^ (i + 1);
            if (records[nums[i]] > 0)
            {
                duplicated = nums[i];
            }

            records[nums[i]]++;
        }

        var missed = sumXor ^ duplicated;

        return new[] { duplicated, missed };
    }
}
