namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0023Tests
{
    [TestMethod]
    public void MergeKListsTest()
    {
        var lists = new[]
        {
            ListNode.FromArray(new[] { 1, 4, 5 }),
            ListNode.FromArray(new[] { 1, 3, 4 }),
            ListNode.FromArray(new[] { 2, 6 }),
        };
        var expected = new[] { 1, 1, 2, 3, 4, 4, 5, 6 };
        var leetCode = new LeetCode0023();
        var output = leetCode.MergeKLists(lists);
        var actual = output.ToArray();
        CollectionAssert.AreEqual(expected, actual);
    }
}
