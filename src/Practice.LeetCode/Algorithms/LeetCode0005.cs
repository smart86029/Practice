namespace Practice.LeetCode.Algorithms;

public class LeetCode0005
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }

        var start = 0;
        var end = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var length1 = ExpandAroundCenter(i, i);
            var length2 = ExpandAroundCenter(i, i + 1);
            var length = Math.Max(length1, length2);
            if (length > end - start + 1)
            {
                start = i - (length - 1) / 2;
                end = i + length / 2;
            }
        }

        return s.Substring(start, end - start + 1);

        int ExpandAroundCenter(int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1;
        }
    }
}
