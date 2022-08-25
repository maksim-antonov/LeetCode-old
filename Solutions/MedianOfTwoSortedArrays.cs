namespace LeetCode.Solutions;

public class MedianOfTwoSortedArrays
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums2.Length < nums1.Length) return FindMedianSortedArrays(nums2, nums1);

        var n1 = nums1.Length;
        var n2 = nums2.Length;

        int count;

        int m1 = -1, m2 = -1;

        int low = 0, high = n1;
        int i = 0, j = 0;

        if ((n1 + n2) % 2 == 1)
        {
            for (count = 0; count <= (n1 + n2) / 2; count++)
            {
                if (i != n1 && j != n2)
                {
                    m1 = (nums1[i] > nums2[j]) ? nums2[j++] : nums1[i++];
                }
                else if (i < n1)
                {
                    m1 = nums1[i++];
                }
                else
                {
                    m1 = nums2[j++];
                }
            }

            return m1;
        }

        for (count = 0; count <= (n1 + n2) / 2; count++)
        {
            m2 = m1;
            if (i != n1 && j != n2)
            {
                m1 = (nums1[i] > nums2[j]) ? nums2[j++] : nums1[i++];
            }
            else if (i < n1)
            {
                m1 = nums1[i++];
            }
            else
            {
                m1 = nums2[j++];
            }
        }

        return (m1 + m2) / 2.0;
    }
}