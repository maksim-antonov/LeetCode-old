namespace LeetCode.Solutions;

public class BinarySearch
{
    // 704. Binary Search https://leetcode.com/problems/binary-search
    //Given an array of integers nums which is sorted in ascending order,
    //and an integer target, write a function to search target in nums.
    //If target exists, then return its index. Otherwise, return -1.
    // You must write an algorithm with O(log n) runtime complexity.

    ///<summary>
    /// Search target number index in array using binary search
    /// </summary>
    /// <param name="nums">Array of sorted integers</param>
    /// <param name="target">Target integer</param>
    /// <returns>
    /// Index of target number or "-1" if not found.
    /// </returns>
    public static int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (right >= left)
        {
            var mid = (left + right) / 2;

            if (target == nums[mid])
                return mid;

            if (target < nums[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}