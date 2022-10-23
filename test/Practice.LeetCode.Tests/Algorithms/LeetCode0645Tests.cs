namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0645Tests
{
    [DataTestMethod]
    [DataRow(new int[] { 1, 2, 2, 4 }, new int[] { 2, 3 })]
    [DataRow(new int[] { 1, 1 }, new int[] { 1, 2 })]
    [DataRow(new int[] { 2, 2 }, new int[] { 2, 1 })]
    [DataRow(new int[] { 3, 2, 2 }, new int[] { 2, 1 })]
    [DataRow(new int[] { 8, 7, 3, 5, 3, 6, 1, 4 }, new int[] { 3, 2 })]
    public void FindErrorNumsTest(int[] nums, int[] expected)
    {
        var leetCode = new LeetCode0645();
        var output = leetCode.FindErrorNums(nums);
        CollectionAssert.AreEqual(expected, output);
    }
}
