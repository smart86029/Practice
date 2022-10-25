namespace Practice.LeetCode.Algorithms;

public class LeetCode1662
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        var outer1 = 0;
        var outer2 = 0;
        var inner1 = 0;
        var inner2 = 0;
        while (outer1 < word1.Length && outer2 < word2.Length)
        {
            if (word1[outer1][inner1] != word2[outer2][inner2])
            {
                return false;
            }

            if (inner1 == word1[outer1].Length - 1)
            {
                if (outer1 == word1.Length - 1)
                {
                    return outer2 == word2.Length - 1 && inner2 == word2[outer2].Length - 1;
                }

                outer1++;
                inner1 = 0;
            }
            else
            {
                inner1++;
            }

            if (inner2 == word2[outer2].Length - 1)
            {
                if (outer2 == word2.Length - 1)
                {
                    return false;
                }

                outer2++;
                inner2 = 0;
            }
            else
            {
                inner2++;
            }
        }

        return true;
    }
}
