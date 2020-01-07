using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0029Tests
    {
        [DataTestMethod]
        [DataRow(10, 3, 3)]
        [DataRow(7, -3, -2)]
        [DataRow(int.MinValue, -1, int.MaxValue)]
        [DataRow(int.MinValue, 2, -1073741824)]
        [DataRow(int.MaxValue, 1, int.MaxValue)]
        public void DivideTest(int dividend, int divisor, int expected)
        {
            var leetCode = new LeetCode0029();
            var output = leetCode.Divide(dividend, divisor);
            Assert.AreEqual(expected, output);
        }
    }
}