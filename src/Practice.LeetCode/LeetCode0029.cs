namespace Practice.LeetCode
{
    public class LeetCode0029
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue)
            {
                if (divisor == 1)
                    return int.MinValue;
                if (divisor == -1)
                    return int.MaxValue;
            }

            var result = dividend / divisor;

            return result;
        }
    }
}