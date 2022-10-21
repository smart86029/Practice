namespace Practice.LeetCode.Algorithms;

public class LeetCode0031
{
    public void NextPermutation(int[] nums)
    {
        var i = nums.Length - 2;
        while (i >= 0 && nums[i + 1] <= nums[i])
        {
            i--;
        }

        if (i >= 0)
        {
            var j = nums.Length - 1;
            while (j >= 0 && nums[j] <= nums[i])
            {
                j--;
            }

            Swap(i, j);
        }

        Reverse(i + 1);

        void Swap(int index1, int index2)
        {
            (nums[index2], nums[index1]) = (nums[index1], nums[index2]);
        }

        void Reverse(int start)
        {
            var end = nums.Length - 1;
            while (start < end)
            {
                Swap(start, end);
                start++;
                end--;
            }
        }
    }
}
