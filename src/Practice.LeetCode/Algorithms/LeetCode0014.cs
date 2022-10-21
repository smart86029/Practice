namespace Practice.LeetCode.Algorithms;

public class LeetCode0014
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return string.Empty;
        }

        var first = strs[0];
        for (var i = 0; i < first.Length; i++)
        {
            foreach (var str in strs)
            {
                if (str.Length <= i || first[i] != str[i])
                {
                    return first.Substring(0, i);
                }
            }
        }

        return first;
    }
}
