namespace Practice.LeetCode.Algorithms;

public class LeetCode1154
{
    public int DayOfYear(string date)
    {
        var days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        var parts = date.Split('-');
        var year = int.Parse(parts[0]);
        var month = int.Parse(parts[1]);
        var day = int.Parse(parts[2]);
        var result = day;

        for (var i = 0; i < month - 1; i++)
        {
            result += days[i];
        }

        if (month > 2 && year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            result++;
        }

        return result;
    }
}
