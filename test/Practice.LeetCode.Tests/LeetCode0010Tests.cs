using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0010Tests
    {
        [DataTestMethod]
        [DataRow("aa", "a", false)]
        [DataRow("aa", "a*", true)]
        [DataRow("ab", ".*", true)]
        [DataRow("aab", "c*a*b", true)]
        [DataRow("mississippi", "mis*is*p*.", false)]
        [DataRow("abc", "a.c", true)]
        [DataRow("aaa", "aaaa", false)]
        [DataRow("aaa", "a*a", true)]
        [DataRow("aaa", "ab*a*c*a", true)]
        public void IsMatchTest(string s, string p, bool expected)
        {
            var leetCode = new LeetCode0010();
            var output = leetCode.IsMatch(s, p);
            Assert.AreEqual(expected, output);
        }
    }
}