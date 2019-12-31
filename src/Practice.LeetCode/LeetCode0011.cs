using System;

namespace Practice.LeetCode
{
    public class LeetCode0011
    {
        public int MaxArea(int[] height)
        {
            var result = 0;
            var left = 0;
            var right = height.Length - 1;

            while (left < right)
            {
                result = Math.Max(result, Math.Min(height[left], height[right]) * (right - left));
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return result;
        }
    }
}