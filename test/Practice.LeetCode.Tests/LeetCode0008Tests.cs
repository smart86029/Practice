using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0008Tests
    {
        [DataTestMethod]
        [DataRow("42", 42)]
        [DataRow("   -42", -42)]
        [DataRow("4193 with words", 4193)]
        [DataRow("words and 987", 0)]
        [DataRow("-91283472332", -2147483648)]
        [DataRow("+1", 1)]
        public void ConvertTest(string str, int expected)
        {
            var leetCode = new LeetCode0008();
            var output = leetCode.MyAtoi(str);
            Assert.AreEqual(expected, output);
        }
    }
}