namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0040Tests
{
    [TestMethod]
    public void CombinationSum2Test1()
    {
        var candidates = new int[] { 10, 1, 2, 7, 6, 1, 5 };
        var target = 8;
        var expected = new List<IList<int>>
        {
            new List<int> { 1, 1, 6 },
            new List<int> { 1, 2, 5 },
            new List<int> { 1, 7 },
            new List<int> { 2, 6 },
        };

        var leetCode = new LeetCode0040();
        var output = leetCode.CombinationSum2(candidates, target);
        Assert.AreEqual(expected.Count, output.Count);
        for (var i = 0; i < expected.Count; i++)
        {
            CollectionAssert.AreEqual(expected[i].ToList(), output[i].ToList());
        }
    }

    [TestMethod]
    public void CombinationSum2Test2()
    {
        var candidates = new int[] { 2, 5, 2, 1, 2 };
        var target = 5;
        var expected = new List<IList<int>>
        {
            new List<int> { 1, 2, 2 },
            new List<int> { 5 },
        };

        var leetCode = new LeetCode0040();
        var output = leetCode.CombinationSum2(candidates, target);
        Assert.AreEqual(expected.Count, output.Count);
        for (var i = 0; i < expected.Count; i++)
        {
            CollectionAssert.AreEqual(expected[i].ToList(), output[i].ToList());
        }
    }

    [TestMethod]
    public void CombinationSum2Test3()
    {
        var candidates = new int[] { 3, 1, 3, 5, 1, 1 };
        var target = 8;
        var expected = new List<IList<int>>
        {
            new List<int> { 1, 1, 1, 5 },
            new List<int> { 1, 1, 3, 3 },
            new List<int> { 3, 5 },
        };

        var leetCode = new LeetCode0040();
        var output = leetCode.CombinationSum2(candidates, target);
        Assert.AreEqual(expected.Count, output.Count);
        for (var i = 0; i < expected.Count; i++)
        {
            CollectionAssert.AreEqual(expected[i].ToList(), output[i].ToList());
        }
    }

    [TestMethod]
    public void CombinationSum2Test4()
    {
        var candidates = new int[] { 4, 4, 2, 1, 4, 2, 2, 1, 3 };
        var target = 6;
        var expected = new List<IList<int>>
        {
            new List<int> { 1, 1, 2, 2 },
            new List<int> { 1, 1, 4 },
            new List<int> { 1, 2, 3 },
            new List<int> { 2, 2, 2 },
            new List<int> { 2, 4 },
        };

        var leetCode = new LeetCode0040();
        var output = leetCode.CombinationSum2(candidates, target);
        Assert.AreEqual(expected.Count, output.Count);
        for (var i = 0; i < expected.Count; i++)
        {
            CollectionAssert.AreEqual(expected[i].ToList(), output[i].ToList());
        }
    }
}
