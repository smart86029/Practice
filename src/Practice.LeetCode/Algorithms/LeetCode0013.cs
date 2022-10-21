namespace Practice.LeetCode.Algorithms;

public class LeetCode0013
{
    public int RomanToInt(string s)
    {
        var map = new Dictionary<char, int>
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000,
        };
        var result = 0;
        var temps = new Stack<char>();

        foreach (var c in s)
        {
            switch (c)
            {
                case 'M':
                case 'D':
                    if (temps.Any() && temps.Peek() == 'C')
                    {
                        var temp = temps.Pop();
                        result -= map[temp];
                    }

                    result += map[c];
                    break;

                case 'C':
                case 'L':
                    if (temps.Any() && temps.Peek() == 'X')
                    {
                        var temp = temps.Pop();
                        result -= map[temp];
                    }

                    temps.Push(c);
                    break;

                case 'X':
                case 'V':
                    if (temps.Any() && temps.Peek() == 'I')
                    {
                        var temp = temps.Pop();
                        result -= map[temp];
                    }

                    temps.Push(c);
                    break;

                case 'I':
                    temps.Push(c);
                    break;
            }
        }

        while (temps.Any())
        {
            result += map[temps.Pop()];
        }

        return result;
    }
}
