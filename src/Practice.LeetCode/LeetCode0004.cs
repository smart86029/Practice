namespace Practice.LeetCode
{
    public class LeetCode0004
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var length1 = nums1.Length;
            var length2 = nums2.Length;
            var lengthTotal = length1 + length2;
            var median = lengthTotal % 2 == 0 ? lengthTotal / 2 + 1 : (lengthTotal + 1) / 2;
            var index1 = 0;
            var index2 = 0;
            var current = 0;
            var previous = 0;

            for (var i = 0; i < median; i++)
            {
                previous = current;
                if (index1 < length1 && index2 < length2)
                {
                    if (nums1[index1] < nums2[index2])
                    {
                        current = nums1[index1];
                        index1++;
                    }
                    else
                    {
                        current = nums2[index2];
                        index2++;
                    }
                }
                else if (index1 < length1)
                {
                    current = nums1[index1];
                    index1++;
                }
                else if (index2 < length2)
                {
                    current = nums2[index2];
                    index2++;
                }
            }

            return lengthTotal % 2 == 0 ? (current + previous) / 2.0 : current;
        }
    }
}