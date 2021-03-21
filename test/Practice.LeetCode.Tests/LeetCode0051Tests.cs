using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0051Tests
    {
        [TestMethod]
        public void SolveNQueensTest()
        {
            var leetCode = new LeetCode0051();
            var expected = new List<IList<string>>
            {
                new List<string> { "Q" },
            } as IList<IList<string>>;
            var output = leetCode.SolveNQueens(8);

            Console.WriteLine(output[0]);
        }
    }
}