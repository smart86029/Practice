namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode1110Tests
{
    [TestMethod]
    public void DelNodesTest()
    {
        var nums = new int?[] { 1, 2, 3, 4, 5, 6, 7 };
        var toDelete = new int[] { 3, 5 };
        var expected = new int?[][]
        {
            new int?[] { 1, 2, null, 4 },
            new int?[] { 6 },
            new int?[] { 7 },
        };
        var leetCode = new LeetCode1110();
        var output = leetCode.DelNodes(TreeNode.FromArray(nums), toDelete);
        var actual = output.Select(x => x.ToArray()).ToArray();

        Assert.AreEqual(expected.Length, actual.Length);
        for (var i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEqual(expected[i], actual[i]);
        }
    }
}
