using System.Linq;

namespace Practice.LeetCode
{
    public class LeetCode0036
    {
        public bool IsValidSudoku(char[][] board)
        {
            var nineNumbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (var i = 0; i < 9; i++)
            {
                var row = board[i].Where(x => x != '.').ToArray();
                if (row.Distinct().Count() != row.Count())
                    return false;

                var column = nineNumbers.Select(x => board[x - 1][i]).Where(x => x != '.').ToArray();
                if (column.Distinct().Count() != column.Count())
                    return false;

                var subBox = new int[9];
                var subA = i / 3;
                var subB = i % 3;
                for (var p = 0; p < 3; p++)
                    for (var q = 0; q < 3; q++)
                        subBox[p * 3 + q] = board[subA * 3 + p][subB * 3 + q];
                if (subBox.Where(x => x != '.').Distinct().Count() != subBox.Where(x => x != '.').Count())
                    return false;
            }

            return true;
        }
    }
}