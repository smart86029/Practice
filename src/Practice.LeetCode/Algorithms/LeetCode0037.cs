namespace Practice.LeetCode.Algorithms;

public class LeetCode0037
{
    public void SolveSudoku(char[][] board)
    {
        var row = new bool[10, 10];
        var col = new bool[10, 10];
        var box = new bool[10, 10];

        for (var i = 0; i < 9; i++)
        {
            for (var j = 0; j < 9; j++)
            {
                if (board[i][j] != '.')
                {
                    row[i, board[i][j] - '0'] = true;
                    col[j, board[i][j] - '0'] = true;
                    var k = i / 3 * 3 + j / 3;
                    box[k, board[i][j] - '0'] = true;
                }
            }
        }

        Dfs(0, 0);

        bool Dfs(int x, int y)
        {
            if (x == 8 && y == 9)
            {
                return true;
            }
            else if (y == 9)
            {
                y = 0;
                x += 1;
            }

            if (board[x][y] == '.')
            {
                for (var i = 1; i <= 9; i++)
                {
                    if (IsValid(i, x, y))
                    {
                        row[x, i] = true;
                        col[y, i] = true;
                        var b = x / 3 * 3 + y / 3;
                        box[b, i] = true;
                        board[x][y] = (char)(i + '0');
                        if (Dfs(x, y + 1))
                        {
                            return true;
                        }

                        board[x][y] = '.';
                        row[x, i] = false;
                        col[y, i] = false;
                        box[b, i] = false;
                    }
                }
            }
            else
            {
                return Dfs(x, y + 1);
            }

            return false;
        }

        bool IsValid(int i, int x, int y)
        {
            if (row[x, i])
            {
                return false;
            }

            if (col[y, i])
            {
                return false;
            }

            var b = x / 3 * 3 + y / 3;

            return !box[b, i];
        }
    }
}
