namespace Practice.LeetCode.Algorithms;

public class LeetCode0003
{
    public int LengthOfLongestSubstring(string s)
    {
        var result = 0;
        var temp = 0;
        var map = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (map.ContainsKey(c))
            {
                temp = Math.Max(temp, map[c] + 1);
                map.Remove(c);
            }

            map[c] = i;
            result = Math.Max(result, i - temp + 1);
        }

        return result;
    }
}
