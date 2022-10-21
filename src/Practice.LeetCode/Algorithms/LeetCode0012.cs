namespace Practice.LeetCode.Algorithms;

public class LeetCode0012
{
    public string IntToRoman(int num)
    {
        var result = new StringBuilder();

        Append(num / 1000, 'M', 'M', 'M');

        num %= 1000;
        Append(num / 100, 'M', 'D', 'C');

        num %= 100;
        Append(num / 10, 'C', 'L', 'X');

        num %= 10;
        Append(num, 'X', 'V', 'I');

        return result.ToString();

        void Append(int number, char ten, char five, char one)
        {
            switch (number)
            {
                case 4:
                    result.Append(one);
                    result.Append(five);
                    break;

                case 9:
                    result.Append(one);
                    result.Append(ten);
                    break;

                default:
                    if (number > 4)
                    {
                        result.Append(five);
                    }

                    for (var i = 0; i < number % 5; i++)
                    {
                        result.Append(one);
                    }

                    break;
            }
        }
    }
}
