namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0005Tests
{
    [DataTestMethod]
    [DataRow("babad", "bab")]
    [DataRow("cbbd", "bb")]
    public void LongestPalindromeTest(string s, string expected)
    {
        var leetCode = new LeetCode0005();
        var output = leetCode.LongestPalindrome(s);
        Assert.AreEqual(expected, output);
    }
}
