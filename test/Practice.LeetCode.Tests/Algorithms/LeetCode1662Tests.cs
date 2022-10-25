namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode1662Tests
{
    [DataTestMethod]
    [DataRow(new[] { "ab", "c" }, new[] { "a", "bc" }, true)]
    [DataRow(new[] { "a", "cb" }, new[] { "ab", "c" }, false)]
    [DataRow(new[] { "abc", "d", "defg" }, new[] { "abcddefg" }, true)]
    public void ArrayStringsAreEqualTest(string[] word1, string[] word2, bool expected)
    {
        var leetCode = new LeetCode1662();
        var output = leetCode.ArrayStringsAreEqual(word1, word2);
        Assert.AreEqual(expected, output);
    }
}
