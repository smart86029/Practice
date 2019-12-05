namespace Practice.LeetCode
{
    public class LeetCode0645
    {
        public int[] FindErrorNums(int[] nums)
        {
            var count = nums.Length;
            var records = new int[count];
            var duplicated = 0;
            var sum = 0;

            for (var i = 0; i < count; i++)
            {
                var num = nums[i];
                sum += num;
                if (records[num - 1] > 0)
                    duplicated = num;
                else
                    records[num - 1]++;
            }

            var expectedSum = (count + 1) * count / 2;
            var missed = duplicated + expectedSum - sum;
            var result = new int[] { duplicated, missed };

            return result;
        }
    }
}