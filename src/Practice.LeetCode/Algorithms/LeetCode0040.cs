namespace Practice.LeetCode.Algorithms;

public class LeetCode0040
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var results = new List<IList<int>>();

        Backtrack(target, 0, new List<int>());

        return results;

        void Backtrack(int target, int start, IList<int> list)
        {
            if (target == 0)
            {
                results.Add(list);
                return;
            }

            for (var i = start; i < candidates.Length; i++)
            {
                var candidate = candidates[i];
                if (candidate > target)
                {
                    break;
                }

                if (i > start && candidate == candidates[i - 1])
                {
                    continue;
                }

                var nextTarget = target - candidate;
                var nextList = new List<int>(list)
                {
                    candidate,
                };

                Backtrack(nextTarget, i + 1, nextList);
            }
        }
    }
}
