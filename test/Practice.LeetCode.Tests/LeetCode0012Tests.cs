using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0012Tests
    {
        [DataTestMethod]
        [DataRow(3, "III")]
        [DataRow(4, "IV")]
        [DataRow(9, "IX")]
        [DataRow(58, "LVIII")]
        [DataRow(1994, "MCMXCIV")]
        public void IntToRomanTest(int num, string expected)
        {
            var leetCode = new LeetCode0012();
            var output = leetCode.IntToRoman(num);
            Assert.AreEqual(expected, output);
        }
    }
}