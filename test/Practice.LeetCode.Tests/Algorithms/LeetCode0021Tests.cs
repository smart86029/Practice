namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0021Tests
{
    [DataTestMethod]
    [DataRow(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
    public void MergeTwoListsTest(int[] num1, int[] num2, int[] expected)
    {
        var l1 = ListNode.FromArray(num1);
        var l2 = ListNode.FromArray(num2);
        var leetCode = new LeetCode0021();
        var output = leetCode.MergeTwoLists(l1, l2);
        var actual = output.ToArray();
        CollectionAssert.AreEqual(expected, actual);
    }
}
