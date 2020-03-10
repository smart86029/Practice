using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.LeetCode
{
    public class LeetCode0032
    {
        public int LongestValidParentheses(string s)
        {
            var max = 0;
            var stack = new Stack<int>();
            stack.Push(-1);

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else
                {
                    stack.Pop();
                    if (!stack.Any())
                        stack.Push(i);
                    else
                        max = Math.Max(max, i - stack.Peek());
                }
            }

            return max;
        }
    }
}