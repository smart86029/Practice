using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0022Tests
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(new[] { "((()))", "(()())", "(())()", "()(())", "()()()" }, 3)]
        public void GenerateParenthesisTest(string[] expected, int n)
        {
            var leetCode = new LeetCode0022();
            var output = leetCode.GenerateParenthesis(n);
            CollectionAssert.AreEqual(expected, output.ToArray());
        }
    }
}