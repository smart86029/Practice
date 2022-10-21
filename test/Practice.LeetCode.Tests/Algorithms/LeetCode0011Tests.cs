namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0011Tests
{
    [DataTestMethod]
    [DataRow(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    public void MaxAreaTest(int[] height, int expected)
    {
        var leetCode = new LeetCode0011();
        var output = leetCode.MaxArea(height);
        Assert.AreEqual(expected, output);
    }
}
