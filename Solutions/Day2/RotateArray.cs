namespace LeetCode.Solutions.Day2;

public class RotateArray
{
    //Given an array, rotate the array to the right by k steps, where k is non-negative.
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        var left = 0;
        var right = nums.Length - 1;

        Reverse(nums, left, right); // while left < right --- swap left with right
        Reverse(nums, left, k - 1); // while left < k - 1 --- swap left with k - 1
        Reverse(nums, k, right); // while k < right --- swap k with right
    }

    public void Reverse(int[] ar, int i, int j)
    {
        while (i < j)
        {
            (ar[i], ar[j]) = (ar[j], ar[i]);
            i++;
            j--;
        }
    }
}