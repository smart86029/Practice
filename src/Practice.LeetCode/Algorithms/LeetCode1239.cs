namespace Practice.LeetCode.Algorithms;

public class LeetCode1239
{
    public int MaxLength(IList<string> arr)
    {
        var result = 0;
        var uniques = new int[arr.Count];
        for (var i = 0; i < arr.Count; i++)
        {
            var binary = 0;
            for (var j = 0; j < arr[i].Length; j++)
            {
                var bit = 1 << (arr[i][j] - 'a');
                if ((binary & bit) > 0)
                {
                    binary = 0;
                    break;
                }

                binary |= bit;
            }

            uniques[i] = binary;
        }

        var concat = new List<(int Bit, int Length)> { (0, 0) };
        for (var i = 0; i < uniques.Length; i++)
        {
            if (uniques[i] == 0)
            {
                continue;
            }

            for (var j = concat.Count - 1; j >= 0; j--)
            {
                if ((concat[j].Bit & uniques[i]) == 0)
                {
                    var bit = concat[j].Bit | uniques[i];
                    var length = concat[j].Length + arr[i].Length;
                    concat.Add((bit, length));
                    result = Math.Max(result, length);
                }
            }
        }

        return result;
    }
}
