namespace Practice.LeetCode.Algorithms;

public class LeetCode0076
{
    public string MinWindow(string s, string t)
    {
        var counts = t.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        var window = t.GroupBy(x => x).ToDictionary(x => x.Key, x => 0);
        var validCount = 0;
        var left = 0;
        var right = 0;
        var start = 0;
        var length = int.MaxValue;
        while (right < s.Length)
        {
            var charRight = s[right];
            right++;
            if (counts.TryGetValue(charRight, out var countRight))
            {
                window[charRight]++;
                if (window[charRight] == countRight)
                {
                    validCount++;
                }
            }

            while (validCount == counts.Count)
            {
                if (right - left < length)
                {
                    start = left;
                    length = right - left;
                }

                var charLeft = s[left];
                left++;
                if (counts.TryGetValue(charLeft, out var countLeft))
                {
                    if (window[charLeft] == countLeft)
                    {
                        validCount--;
                    }

                    window[charLeft]--;
                }
            }
        }

        return length == int.MaxValue ? string.Empty : s.Substring(start, length);
    }
}
