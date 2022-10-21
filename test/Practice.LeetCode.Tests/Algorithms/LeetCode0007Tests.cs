namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0007Tests
{
    [DataTestMethod]
    [DataRow(123, 321)]
    [DataRow(-123, -321)]
    [DataRow(120, 21)]
    [DataRow(int.MinValue, 0)]
    [DataRow(1534236469, 0)]
    public void ReverseTest(int x, int expected)
    {
        var leetCode = new LeetCode0007();
        var output = leetCode.Reverse(x);
        Assert.AreEqual(expected, output);
    }
}
