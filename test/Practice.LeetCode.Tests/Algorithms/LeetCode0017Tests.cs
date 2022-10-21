namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode0017Tests
{
    [TestMethod]
    public void LetterCombinationsTest()
    {
        var digits = "23";
        var expected = new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }.OrderBy(x => x).ToArray();
        var leetCode = new LeetCode0017();
        var output = leetCode.LetterCombinations(digits).OrderBy(x => x).ToList();
        CollectionAssert.AreEqual(expected, output);
    }
}
