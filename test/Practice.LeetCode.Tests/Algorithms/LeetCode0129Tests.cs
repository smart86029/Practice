namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0129Tests
{
    [DataTestMethod]
    [DataRow(new int[] { 1, 2, 3 }, 25)]
    [DataRow(new int[] { }, 0)]
    public void SumNumbersTest(int[] nums, int expected)
    {
        var leetCode = new LeetCode0129();
        var output = leetCode.SumNumbers(TreeNode.FromArray(nums));
        Assert.AreEqual(expected, output);
    }
}
