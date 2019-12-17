namespace Practice.LeetCode
{
    public class LeetCode0010
    {
        public bool IsMatch(string s, string p)
        {
            var result = new bool[s.Length + 1, p.Length + 1];
            result[s.Length, p.Length] = true;

            for (var i = s.Length; i >= 0; i--)
            {
                for (var j = p.Length - 1; j >= 0; j--)
                {
                    var firstMatch = i < s.Length && (p[j] == s[i] || p[j] == '.');
                    if (j + 1 < p.Length && p[j + 1] == '*')
                        result[i, j] = result[i, j + 2] || (firstMatch && result[i + 1, j]);
                    else
                        result[i, j] = firstMatch && result[i + 1, j + 1];
                }
            }

            return result[0, 0];
        }
    }
}