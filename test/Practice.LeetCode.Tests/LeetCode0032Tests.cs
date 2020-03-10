using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0032Tests
    {
        [DataTestMethod]
        [DataRow("(()", 2)]
        [DataRow(")()())", 4)]
        public void NextPermutationTest(string s, int expected)
        {
            var leetCode = new LeetCode0032();
            var output = leetCode.LongestValidParentheses(s);
            Assert.AreEqual(expected, output);
        }
    }
}