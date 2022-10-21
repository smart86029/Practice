namespace Practice.LeetCode.Algorithms;

public class LeetCode0020
{
    public bool IsValid(string s)
    {
        var map = new Dictionary<char, int>
        {
            ['{'] = -3,
            ['['] = -2,
            ['('] = -1,
            [')'] = 1,
            [']'] = 2,
            ['}'] = 3,
        };
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            var num = map[c];
            if (num < 0)
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                var pop = map[stack.Pop()];
                if (pop + num != 0)
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
