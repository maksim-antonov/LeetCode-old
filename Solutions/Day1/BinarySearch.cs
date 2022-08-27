namespace LeetCode.Solutions.Day1;

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


    //35. Search Insert Position https://leetcode.com/problems/search-insert-position/
    //Given a sorted array of distinct integers and a target value,
    //return the index if the target is found. If not, return the index where it would be if it were inserted in order.
    // You must write an algorithm with O(log n) runtime complexity.
    /// <summary>
    /// Search target number index in array using binary search or index where it would be stay if were inserted in order
    /// </summary>
    /// <param name="nums">Array of sorted integers</param>
    /// <param name="target">Target integer</param>
    /// <returns>Index if the target is found. If not, the index where it would be if it were inserted in order.</returns>
    /// <example>Input: nums = [1,3,5,6], target = 5; Output: 2</example>
    public static int SearchInsert(int[] nums, int target)
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

        return left;
    }

    public static int First(int n)
    {
        long low = 1;
        long high = n;
        while (high >= low)
        {
            long mid = (low + high) / 2;
            if (!IsBadVersion((int) mid))
                low = mid + 1;
            else
            {
                high = mid - 1;
            }
        }
    
        return (int) low;
    }
}