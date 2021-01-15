using System;
using System.Collections.Generic;

namespace Practice.LeetCode
{
    public class LeetCode0039
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            var dp = new List<List<IList<int>>>();

            for (var i = 1; i <= target; i++)
            {
                var temp = new List<IList<int>>();
                for (var j = 0; j < candidates.Length; j++)
                {
                    var candidate = candidates[j];
                    if (candidate == i)
                    {
                        temp.Add(new List<int> { candidate });
                    }
                    else if (candidate < i)
                    {
                        foreach (var list in dp[i - candidate - 1])
                        {
                            if (candidate <= list[0])
                            {
                                var newList = new List<int> { candidate };
                                newList.AddRange(list);
                                temp.Add(newList);
                            }
                        }
                    }
                }
                dp.Add(temp);
            }

            return dp[target - 1];
        }
    }
}