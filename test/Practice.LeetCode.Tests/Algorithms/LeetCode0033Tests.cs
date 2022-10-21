namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0033Tests
{
    [DataTestMethod]
    [DataRow(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
    [DataRow(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
    public void SearchTest(int[] nums, int target, int expected)
    {
        var leetCode = new LeetCode0033();
        var output = leetCode.Search(nums, target);
        Assert.AreEqual(expected, output);
    }
}
