namespace Practice.LeetCode.Algorithms;

public class LeetCode0009
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        var temp = x;
        var reverse = 0;

        while (temp > 0)
        {
            reverse = reverse * 10 + temp % 10;
            temp /= 10;
        }

        return x == reverse;
    }
}
