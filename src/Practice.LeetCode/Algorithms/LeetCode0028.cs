namespace Practice.LeetCode.Algorithms;

public class LeetCode0028
{
    public int StrStr(string haystack, string needle)
    {
        if (needle == string.Empty)
        {
            return 0;
        }

        for (var i = 0; i < haystack.Length - needle.Length + 1; i++)
        {
            var allSame = true;
            for (var j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    allSame = false;
                    break;
                }
            }

            if (allSame)
            {
                return i;
            }
        }

        return -1;
    }
}
