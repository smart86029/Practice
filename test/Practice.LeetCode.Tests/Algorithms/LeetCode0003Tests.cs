namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0003Tests
{
    [DataTestMethod]
    [DataRow("abcabcbb", 3)]
    [DataRow("bbbbb", 1)]
    [DataRow("pwwkew", 3)]
    [DataRow(" ", 1)]
    public void LengthOfLongestSubstringTest(string s, int expected)
    {
        var leetCode = new LeetCode0003();
        var output = leetCode.LengthOfLongestSubstring(s);
        Assert.AreEqual(expected, output);
    }
}
