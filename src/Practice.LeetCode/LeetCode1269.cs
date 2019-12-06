using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LeetCode
{
    public class LeetCode1269
    {
        public int NumWays(int steps, int arrLen)
        {
            var result = 0;

            if (steps % 2 == 0)
            {
                for (var i = 0; i < arrLen; i += 2)
                {
                    var move = (arrLen - i) / 2;
                }
            }

            return result;
        }
    }
}
