using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0028Tests
    {
        [DataTestMethod]
        [DataRow("hello", "ll", 2)]
        [DataRow("aaaaa", "bba", -1)]
        [DataRow("", "", 0)]
        [DataRow("mississippi", "issipi", -1)]
        public void StrStrTest(string haystack, string needle, int expected)
        {
            var leetCode = new LeetCode0028();
            var output = leetCode.StrStr(haystack, needle);
            Assert.AreEqual(expected, output);
        }
    }
}