namespace LeetCode.Solutions.Day3;

public class MoveZeroes
{
    
    /* 283. Move Zeroes https://leetcode.com/problems/move-zeroes/
     * Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
     * Note that you must do this in-place without making a copy of the array.
     * Input: nums = [0,1,0,3,12]
     * Output: [1,3,12,0,0]
     */ 
    public void Result(int[] nums)
    {
        for (int i = 0, j = 0; j < nums.Length; j++)
        {
            if (nums[j] == 0) continue;
            (nums[j], nums[i]) = (nums[i], nums[j]);
            i++;
        }
    }
}