using System.Collections.Generic;
using System.Linq;

namespace Practice.LeetCode
{
    public class LeetCode0015
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            var sorted = nums.OrderBy(x => x).ToArray();

            for (var i = 0; i < sorted.Length; i++)
            {
                if (i > 0 && sorted[i] == sorted[i - 1])
                    continue;

                var j = i + 1;
                var k = sorted.Length - 1;
                while (j < k)
                {
                    if (sorted[i] + sorted[j] + sorted[k] > 0)
                        k--;
                    else if (sorted[i] + sorted[j] + sorted[k] < 0)
                        j++;
                    else
                    {
                        result.Add(new List<int> { sorted[i], sorted[j], sorted[k] });
                        j++;
                        k--;
                        while (j < k && sorted[j] == sorted[j - 1])
                            j++;
                        while (j < k && sorted[k] == sorted[k + 1])
                            k--;
                    }
                }
            }

            return result;
        }
    }
}