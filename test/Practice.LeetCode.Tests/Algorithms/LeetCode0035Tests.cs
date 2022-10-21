namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0035Tests
{
    [DataTestMethod]
    [DataRow(new[] { 1, 3, 5, 6 }, 5, 2)]
    [DataRow(new[] { 1, 3, 5, 6 }, 2, 1)]
    [DataRow(new[] { 1, 3, 5, 6 }, 7, 4)]
    [DataRow(new[] { 1, 3, 5, 6 }, 0, 0)]
    [DataRow(new[] { 1, 3 }, 2, 1)]
    [DataRow(new[] { 1, 2, 4, 6, 7 }, 3, 2)]
    public void SearchInsertTest(int[] nums, int target, int expected)
    {
        var leetCode = new LeetCode0035();
        var output = leetCode.SearchInsert(nums, target);
        Assert.AreEqual(expected, output);
    }
}
