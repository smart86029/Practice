using System.Collections.Generic;
using System.Linq;

namespace Practice.LeetCode
{
    public class LeetCode0030
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            var result = new List<int>();
            if (string.IsNullOrEmpty(s) || words.Length == 0)
                return result;

            var map = words.ToLookup(x => x).ToDictionary(x => x.Key, x => x.Count());
            var wordLength = words[0].Length;
            var subStringLength = wordLength * words.Length;
            for (var i = 0; i < wordLength; i++)
            {
                var left = i;

                while (left <= s.Length - subStringLength)
                {
                    var unused = map.ToDictionary(x => x.Key, x => x.Value);
                    var right = left + subStringLength;
                    var interrupt = false;

                    while (right > left)
                    {
                        var subString = s.Substring(right - wordLength, wordLength);
                        if (!unused.ContainsKey(subString) || unused[subString] <= 0)
                        {
                            interrupt = true;
                            break;
                        }

                        unused[subString]--;
                        right -= wordLength;
                    }
                    if (interrupt)
                    {
                        left = right;
                        continue;
                    }

                    result.Add(left);
                    left += wordLength;
                }
            }

            return result;
        }
    }
}