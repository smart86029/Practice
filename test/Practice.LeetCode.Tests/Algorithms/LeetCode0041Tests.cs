namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0041Tests
{
    [DataTestMethod]
    [DataRow(new[] { 1, 2, 0 }, 3)]
    [DataRow(new[] { 3, 4, -1, 1 }, 2)]
    [DataRow(new[] { 7, 8, 9, 11, 12 }, 1)]
    [DataRow(new[] { 1, 1 }, 2)]
    public void FirstMissingPositiveTest(int[] nums, int expected)
    {
        var leetCode = new LeetCode0041();
        var output = leetCode.FirstMissingPositive(nums);
        Assert.AreEqual(expected, output);
    }
}
