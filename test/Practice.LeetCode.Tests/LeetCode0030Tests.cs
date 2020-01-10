using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0030Tests
    {
        [DataTestMethod]
        [DataRow("barfoothefoobarman", new[] { "foo", "bar" }, new[] { 0, 9 })]
        [DataRow("wordgoodgoodgoodbestword", new[] { "word", "good", "best", "word" }, new int[] { })]
        [DataRow("wordgoodgoodgoodbestword", new[] { "word", "good", "best", "good" }, new int[] { 8 })]
        public void FindSubstringTest(string s, string[] words, int[] expected)
        {
            var leetCode = new LeetCode0030();
            var output = leetCode.FindSubstring(s, words);
            CollectionAssert.AreEqual(expected, output.ToArray());
        }
    }
}