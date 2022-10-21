namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0019Tests
{
    [DataTestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 1, 2, 3, 5 })]
    public void RemoveNthFromEndTest(int[] nums, int n, int[] expected)
    {
        var head = ListNode.FromArray(nums);
        var leetCode = new LeetCode0019();
        var output = leetCode.RemoveNthFromEnd(head, n);
        var actual = output.ToArray();
        CollectionAssert.AreEqual(expected, actual);
    }
}
