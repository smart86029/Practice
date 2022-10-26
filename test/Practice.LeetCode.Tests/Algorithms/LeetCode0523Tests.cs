namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0523Tests
{
    [DataTestMethod]
    [DataRow(new[] { 23, 2, 4, 6, 7 }, 6, true)]
    [DataRow(new[] { 23, 2, 6, 4, 7 }, 6, true)]
    [DataRow(new[] { 23, 2, 6, 4, 7 }, 13, false)]
    [DataRow(new[] { 23, 2, 4, 6, 6 }, 7, true)]
    public void CheckSubarraySumTest(int[] nums, int k, bool expected)
    {
        var leetCode = new LeetCode0523();
        var output = leetCode.CheckSubarraySum(nums, k);
        Assert.AreEqual(expected, output);
    }
}
