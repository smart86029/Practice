namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0024Tests
{
    [DataTestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 2, 1, 4, 3 })]
    public void SwapPairsTest(int[] head, int[] expected)
    {
        var leetCode = new LeetCode0024();
        var output = leetCode.SwapPairs(ListNode.FromArray(head));
        var actual = output.ToArray();
        CollectionAssert.AreEqual(expected, actual);
    }
}
