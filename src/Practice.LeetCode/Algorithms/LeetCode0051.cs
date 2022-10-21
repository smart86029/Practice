namespace Practice.LeetCode.Algorithms;

public class LeetCode0051
{
    public IList<IList<string>> SolveNQueens(int n)
    {
        var results = new List<IList<string>>();
        var chess = new int[n][];

        for (var i = 0; i < n; i++)
        {
            chess[i] = new int[n];
        }

        Backtracking(new List<string>(), 0);

        return results;

        void Backtracking(List<string> last, int row)
        {
            if (row == chess.Length)
            {
                results.Add(new List<string>(last));
                return;
            }

            for (var column = 0; column < chess.Length; column++)
            {
                if (IsValidQueen(row, column))
                {
                    chess[row][column] = 1;
                    var arr = new char[chess.Length];
                    Array.Fill(arr, '.');
                    arr[column] = 'Q';
                    last.Add(new string(arr));
                    Backtracking(last, row + 1);
                    last.RemoveAt(last.Count - 1);
                    chess[row][column] = 0;
                }
            }
        }

        bool IsValidQueen(int row, int column)
        {
            for (int i = row - 1, j = column; i >= 0; i--)
            {
                if (chess[i][j] == 1)
                {
                    return false;
                }
            }

            for (int i = row - 1, j = column - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (chess[i][j] == 1)
                {
                    return false;
                }
            }

            for (int i = row - 1, j = column + 1; i >= 0 && j < chess.Length; i--, j++)
            {
                if (chess[i][j] == 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
