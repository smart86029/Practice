namespace Practice.LeetCode.Algorithms;

public class LeetCode0781
{
    public int NumRabbits(int[] answers)
    {
        var result = 0;
        var map = new Dictionary<int, int>();

        foreach (var answer in answers)
        {
            if (map.ContainsKey(answer))
            {
                map[answer]++;
            }
            else
            {
                map[answer] = 1;
            }
        }

        foreach (var pair in map)
        {
            if (pair.Key + 1 == pair.Value)
            {
                result += pair.Value;
            }
            else if (pair.Key + 1 > pair.Value)
            {
                result += pair.Key + 1;
            }
            else
            {
                var other = 0;
                while (other < pair.Value)
                {
                    other += pair.Key + 1;
                }

                result += other;
            }
        }

        return result;
    }
}
