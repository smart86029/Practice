namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0013Tests
{
    [DataTestMethod]
    [DataRow("III", 3)]
    [DataRow("IV", 4)]
    [DataRow("IX", 9)]
    [DataRow("LVIII", 58)]
    [DataRow("MCMXCIV", 1994)]
    public void RomanToIntTest(string s, int expected)
    {
        var leetCode = new LeetCode0013();
        var output = leetCode.RomanToInt(s);
        Assert.AreEqual(expected, output);
    }
}
