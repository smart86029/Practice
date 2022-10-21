namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0018Tests
{
    [TestMethod]
    public void FourSumTest()
    {
        var nums = new int[] { 1, 0, -1, 0, -2, 2 };
        var expected = new List<IList<int>>
        {
            new List<int> { -2, -1, 1, 2 },
            new List<int> { -2, 0, 0, 2 },
            new List<int> { -1, 0, 0, 1 },
        };
        var target = 0;

        var leetCode = new LeetCode0018();
        var output = leetCode.FourSum(nums, target);
        Assert.AreEqual(expected.Count, output.Count);
        for (var i = 0; i < expected.Count; i++)
        {
            CollectionAssert.AreEqual(expected[i].ToList(), output[i].ToList());
        }
    }
}
