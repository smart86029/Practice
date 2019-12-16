using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0014Tests
    {
        [DataTestMethod]
        [DataRow(new string[] { "flower", "flow", "flight" }, "fl")]
        [DataRow(new string[] { "aa", "a" }, "a")]
        public void LongestCommonPrefixTest(string[] strs, string expected)
        {
            var leetCode = new LeetCode0014();
            var output = leetCode.LongestCommonPrefix(strs);
            Assert.AreEqual(expected, output);
        }
    }
}