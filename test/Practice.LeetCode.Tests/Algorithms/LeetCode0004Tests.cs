namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0004Tests
{
    [DataTestMethod]
    [DataRow(new[] { 1, 3 }, new[] { 2 }, 2)]
    [DataRow(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
    public void FindMedianSortedArraysTest(int[] nums1, int[] nums2, double expected)
    {
        var leetCode = new LeetCode0004();
        var output = leetCode.FindMedianSortedArrays(nums1, nums2);
        Assert.AreEqual(expected, output);
    }
}
