using System;
using System.Linq;

namespace Practice.LeetCode
{
    public class LeetCode0016
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            var result = default(int?);
            var sorted = nums.OrderBy(x => x).ToArray();

            for (var i = 0; i < sorted.Length; i++)
            {
                if (i > 0 && sorted[i] == sorted[i - 1])
                    continue;

                var j = i + 1;
                var k = sorted.Length - 1;
                while (j < k)
                {
                    var sum = sorted[i] + sorted[j] + sorted[k];
                    if (result == default)
                        result = sum;

                    result = Math.Abs(result.Value - target) < Math.Abs(sum - target) ? result : sum;
                    if (sorted[i] + sorted[j] + sorted[k] > target)
                        k--;
                    else if (sorted[i] + sorted[j] + sorted[k] < target)
                        j++;
                    else
                        return target;
                }
            }

            return result.GetValueOrDefault();
        }
    }
}