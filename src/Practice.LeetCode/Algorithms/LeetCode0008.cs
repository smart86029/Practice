namespace Practice.LeetCode.Algorithms;

public class LeetCode0008
{
    public int MyAtoi(string str)
    {
        var result = 0;
        var sign = default(bool?);
        var map = new Dictionary<char, int>
        {
            ['0'] = 0,
            ['1'] = 1,
            ['2'] = 2,
            ['3'] = 3,
            ['4'] = 4,
            ['5'] = 5,
            ['6'] = 6,
            ['7'] = 7,
            ['8'] = 8,
            ['9'] = 9,
        };

        foreach (var c in str)
        {
            if (!sign.HasValue)
            {
                switch (c)
                {
                    case ' ':
                        continue;

                    case '-':
                        sign = false;
                        continue;

                    case '+':
                        sign = true;
                        continue;

                    case var n when map.ContainsKey(n):
                        sign = true;
                        break;

                    default:
                        return GetResult();
                }
            }

            if (map.TryGetValue(c, out var number))
            {
                if (sign.GetValueOrDefault() &&
                    (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && number > 7)))
                {
                    return int.MaxValue;
                }

                if (!sign.GetValueOrDefault() &&
                    (result > int.MinValue / -10 || (result == int.MinValue / -10 && number > 8)))
                {
                    return int.MinValue;
                }

                result = result * 10 + number;
            }
            else
            {
                return GetResult();
            }
        }

        return GetResult();

        int GetResult()
        {
            return result * (sign.GetValueOrDefault() ? 1 : -1);
        }
    }
}
