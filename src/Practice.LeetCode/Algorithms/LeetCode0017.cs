namespace Practice.LeetCode.Algorithms;

public class LeetCode0017
{
    public IList<string> LetterCombinations(string digits)
    {
        var map = new Dictionary<char, string>
        {
            ['2'] = "abc",
            ['3'] = "def",
            ['4'] = "ghi",
            ['5'] = "jkl",
            ['6'] = "mno",
            ['7'] = "pqrs",
            ['8'] = "tuv",
            ['9'] = "wxyz",
        };
        var result = new List<string>();

        foreach (var digit in digits)
        {
            var temp = new List<string>();
            foreach (var c in map[digit])
            {
                if (!result.Any())
                {
                    temp.Add(c.ToString());
                }
                else
                {
                    temp.AddRange(result.Select(x => x + c));
                }
            }

            result = temp;
        }

        return result;
    }
}
