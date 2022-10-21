namespace Practice.LeetCode.Algorithms;

public class LeetCode0006
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }

        var result = new StringBuilder();
        var lengthCycle = 2 * numRows - 2;

        for (var i = 0; i < numRows; i++)
        {
            for (var j = 0; i + j < s.Length; j += lengthCycle)
            {
                result.Append(s[i + j]);
                if (i != 0 &&
                    i != numRows - 1 &&
                    j + lengthCycle - i < s.Length)
                {
                    result.Append(s[j + lengthCycle - i]);
                }
            }
        }

        return result.ToString();
    }
}
