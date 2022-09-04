namespace LeetCode.Solutions;

public class SearchInsertPosition
{
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
}