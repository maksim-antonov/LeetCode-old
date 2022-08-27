namespace LeetCode.Solutions.Day2;

public class SquaresOfSortedArray
{
    //Given an integer array nums sorted in non-decreasing order,
    //return an array of the squares of each number sorted in non-decreasing order.
    // Example:
    // Input: nums = [-4,-1,0,3,10]
    // Output: [0,1,9,16,100]
    // Explanation: After squaring, the array becomes [16,1,0,9,100].
    // After sorting, it becomes [0,1,9,16,100].

    public static int[] SortedSquares(int[] nums)
    {
        var arr = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            arr[i] = nums[i] * nums[i];
        }

        QuickSort(arr, 0, arr.Length - 1);

        return arr;
    }

    public static void QuickSort(int[] array, int low, int high)
    {
        if (array.Length == 0)
            return; //завершить выполнение, если длина массива равна 0

        if (low >= high)
            return; //завершить выполнение если уже нечего делить

        // выбрать опорный элемент
        int middle = low + (high - low) / 2;
        int prop = array[middle];

        // разделить на подмассивы, который больше и меньше опорного элемента
        int i = low, j = high;
        while (i <= j)
        {
            while (array[i] < prop)
                i++;

            while (array[j] > prop)
                j--;

            if (i <= j)
            {
                //меняем местами
                (array[i], array[j]) = (array[j], array[i]);
                i++;
                j--;
            }
        }

        // вызов рекурсии для сортировки левой и правой части
        if (low < j)
            QuickSort(array, low, j);

        if (high > i)
            QuickSort(array, i, high);
    }
}