using System.Collections.Generic;
using System.Linq;

namespace Practice.LeetCode
{
    public class LeetCode0018
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            var sorted = nums.OrderBy(x => x).ToArray();
            var candidate = new Stack<int>();

            Backtrack(4, 0, sorted.Length - 1, target);

            return result;

            void Backtrack(int untake, int start, int end, int currentTarget)
            {
                if (untake > end + 1 - start ||
                    currentTarget < untake * sorted[start] ||
                    currentTarget > untake * sorted[end])
                {
                    return;
                }
                else if (untake == 2)
                {
                    var left = start;
                    var right = end;

                    while (left < right)
                    {
                        if (sorted[left] + sorted[right] < currentTarget)
                        {
                            left++;
                        }
                        else if (sorted[left] + sorted[right] > currentTarget)
                        {
                            right--;
                        }
                        else
                        {
                            var solution = new List<int>();
                            solution.AddRange(candidate.Reverse());
                            solution.Add(sorted[left]);
                            solution.Add(sorted[right]);
                            result.Add(solution);

                            left++;
                            right--;
                            while (left < right && sorted[left] == sorted[left - 1])
                                left++;
                            while (left < right && sorted[right] == sorted[right + 1])
                                right--;
                        }
                    }
                }
                else
                {
                    for (var i = start; i < end; i++)
                    {
                        if (i == start || sorted[i] != sorted[i - 1])
                        {
                            candidate.Push(sorted[i]);
                            Backtrack(untake - 1, i + 1, end, currentTarget - sorted[i]);
                            candidate.Pop();
                        }
                    }
                }
            }
        }
    }
}