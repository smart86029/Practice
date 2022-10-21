namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0039Tests
{
    [TestMethod]
    public void CombinationSumTest1()
    {
        var candidates = new[] { 2, 3, 6, 7 };
        var target = 7;
        var expected = new List<IList<int>>
        {
            new List<int> { 2, 2, 3 },
            new List<int> { 7 },
        };

        Test(candidates, target, expected);
    }

    [TestMethod]
    public void CombinationSumTest2()
    {
        var candidates = new[] { 2, 3, 5 };
        var target = 8;
        var expected = new List<IList<int>>
        {
            new List<int> { 2, 2, 2, 2 },
            new List<int> { 2, 3, 3 },
            new List<int> { 3, 5 },
        };

        Test(candidates, target, expected);
    }

    [TestMethod]
    public void CombinationSumTest3()
    {
        var candidates = new[] { 2 };
        var target = 1;
        var expected = new List<IList<int>>
        {
        };

        Test(candidates, target, expected);
    }

    [TestMethod]
    public void CombinationSumTest4()
    {
        var candidates = new[] { 1 };
        var target = 1;
        var expected = new List<IList<int>>
        {
            new List<int> { 1 }
        };

        Test(candidates, target, expected);
    }

    [TestMethod]
    public void CombinationSumTest5()
    {
        var candidates = new[] { 1 };
        var target = 2;
        var expected = new List<IList<int>>
        {
            new List<int> { 1, 1 }
        };

        Test(candidates, target, expected);
    }

    private void Test(int[] candidates, int target, IList<IList<int>> expected)
    {
        var leetCode = new LeetCode0039();
        var output = leetCode.CombinationSum(candidates, target);
        Assert.AreEqual(expected.Count, output.Count);
        for (var i = 0; i < expected.Count; i++)
            CollectionAssert.AreEqual(expected[i].ToList(), output[i].ToList());
    }
}
