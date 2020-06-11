using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0036Tests
    {
        private static IEnumerable<object[]> Data =>
            new[]
            {
                new object[]
                {
                    new[]
                    {
                        new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                        new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                        new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                        new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                        new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                        new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                        new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                        new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                        new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' },
                    },
                    true
                },
            };

        [DataTestMethod]
        [DynamicData(nameof(Data))]
        public void IsValidSudokuTest(char[][] board, bool expected)
        {
            var leetCode = new LeetCode0036();
            var output = leetCode.IsValidSudoku(board);
            Assert.AreEqual(expected, output); 
        }
    }
}