using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0003Tests
    {
        [DataTestMethod]
        [DataRow("abcabcbb", 3)]
        [DataRow("bbbbb", 1)]
        [DataRow("pwwkew", 3)]
        [DataRow(" ", 1)]
        public void LengthOfLongestSubstringTests(string s, int expected)
        {
            var leetCode = new LeetCode0003();
            var output = leetCode.LengthOfLongestSubstring(s);
            Assert.AreEqual(expected, output);
        }
    }
}