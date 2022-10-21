namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0025Tests
{
    [DataTestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 2, 1, 4, 3, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 3, 2, 1, 4, 5 })]
    public void ReverseKGroupTest(int[] head, int k, int[] expected)
    {
        var leetCode = new LeetCode0025();
        var output = leetCode.ReverseKGroup(ListNode.FromArray(head), k);
        var actual = output.ToArray();
        CollectionAssert.AreEqual(expected, actual);
    }
}
