namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0001Tests
{
    [DataTestMethod]
    [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    public void TwoSumTest(int[] nums, int target, int[] expected)
    {
        var leetCode = new LeetCode0001();
        var output = leetCode.TwoSum(nums, target);
        CollectionAssert.AreEqual(expected, output);
    }
}
