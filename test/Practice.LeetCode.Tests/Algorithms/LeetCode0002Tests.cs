namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0002Tests
{
    [DataTestMethod]
    [DataRow(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
    [DataRow(new int[] { 5 }, new int[] { 5 }, new int[] { 0, 1 })]
    public void AddTwoNumbersTest(int[] nums1, int[] nums2, int[] expected)
    {
        var l1 = ListNode.FromArray(nums1);
        var l2 = ListNode.FromArray(nums2);
        var leetCode = new LeetCode0002();
        var output = leetCode.AddTwoNumbers(l1, l2);
        var actual = output.ToArray();
        CollectionAssert.AreEqual(expected, actual);
    }
}
