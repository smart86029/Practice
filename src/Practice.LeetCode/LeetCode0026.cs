namespace Practice.LeetCode
{
    public class LeetCode0026
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == default || nums.Length == 0)
                return 0;

            var next = 0;
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[next])
                {
                    next++;
                    nums[next] = nums[i];
                }
            }

            return next + 1;
        }
    }
}