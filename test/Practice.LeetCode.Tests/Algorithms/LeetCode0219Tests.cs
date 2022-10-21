namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0219Tests
{
    [DataTestMethod]
    [DataRow(new[] { 1, 2, 3, 1 }, 3, true)]
    [DataRow(new[] { 1, 0, 1, 1 }, 1, true)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
    public void ContainsNearbyDuplicateTest(int[] nums, int k, bool expected)
    {
        var leetCode = new LeetCode0219();
        var output = leetCode.ContainsNearbyDuplicate(nums, k);
        Assert.AreEqual(expected, output);
    }
}
