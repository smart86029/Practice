using System;

namespace Practice.LeetCode
{
    public class LeetCode0322
    {
        public int CoinChange(int[] coins, int amount)
        {
            var max = amount + 1;
            var dp = new int[max];
            for (var i = 1; i < max; i++)
                dp[i] = max;

            for (var i = 1; i <= amount; i++)
                for (var j = 0; j < coins.Length; j++)
                    if (coins[j] <= i)
                        dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);

            return dp[amount] > amount ? -1 : dp[amount];
        }
    }
}