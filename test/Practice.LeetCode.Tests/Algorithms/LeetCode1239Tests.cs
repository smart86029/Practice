namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode1239Tests
{
    [DataTestMethod]
    [DataRow(new[] { "un", "iq", "ue" }, 4)]
    [DataRow(new[] { "cha", "r", "act", "ers" }, 6)]
    [DataRow(new[] { "abcdefghijklmnopqrstuvwxyz" }, 26)]
    [DataRow(new[] { "aa", "bb" }, 0)]
    [DataRow(new[] { "abcdefghijklm", "nopqrstuvwxyz", "opqrstuvwxyza", "pqrstuvwxyzab" }, 26)]
    [DataRow(new[] { "abcdefghijklm", "bcdefghijklmn", "cdefghijklmno", "defghijklmnop", "efghijklmnopq", "fghijklmnopqr", "ghijklmnopqrs", "hijklmnopqrst", "ijklmnopqrstu", "jklmnopqrstuv", "klmnopqrstuvw", "lmnopqrstuvwx", "mnopqrstuvwxy", "nopqrstuvwxyz", "opqrstuvwxyza", "pqrstuvwxyzab" }, 26)]
    public void MaxLengthTest(IList<string> arr, int expected)
    {
        var leetCode = new LeetCode1239();
        var output = leetCode.MaxLength(arr);
        Assert.AreEqual(expected, output);
    }
}
