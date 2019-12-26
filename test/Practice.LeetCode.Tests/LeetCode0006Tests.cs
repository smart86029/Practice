using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0006Tests
    {
        [DataTestMethod]
        [DataRow("PAYPALISHIRING", 1, "PAYPALISHIRING")]
        [DataRow("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [DataRow("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        public void ConvertTest(string s, int numRows, string expected)
        {
            var leetCode = new LeetCode0006();
            var output = leetCode.Convert(s, numRows);
            Assert.AreEqual(expected, output);
        }
    }
}