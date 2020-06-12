using System.Text;

namespace Practice.LeetCode
{
    public class LeetCode0038
    {
        public string CountAndSay(int n)
        {
            var result = new string[30];
            result[0] = "1";

            for (var i = 1; i < n; i++)
            {
                var current = new StringBuilder();
                var count = 0;
                var value = char.MaxValue;
                var previous = result[i - 1];

                foreach (var number in previous)
                {
                    if (value == char.MaxValue)
                    {
                        value = number;
                        count++;
                    }
                    else if (value == number)
                    {
                        count++;
                    }
                    else
                    {
                        current.Append($"{count}{value}");
                        value = number;
                        count = 1;
                    }
                }

                current.Append($"{count}{value}");
                result[i] = current.ToString();
            }

            return result[n - 1];
        }
    }
}