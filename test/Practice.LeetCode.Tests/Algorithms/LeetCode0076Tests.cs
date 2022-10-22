namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0076Tests
{
    [DataTestMethod]
    [DataRow("ADOBECODEBANC", "ABC", "BANC")]
    [DataRow("a", "a", "a")]
    [DataRow("a", "aa", "")]
    [DataRow("aa", "aa", "aa")]
    public void MinWindowTest(string s, string t, string expected)
    {
        var leetCode = new LeetCode0076();
        var output = leetCode.MinWindow(s, t);
        Assert.AreEqual(expected, output);
    }
}
