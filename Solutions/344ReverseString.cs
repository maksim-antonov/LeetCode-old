namespace LeetCode.Solutions;

public class ReverseString {
    //https://leetcode.com/problems/reverse-string/
    public void Result(char[] s) {
        // solution #1 (480-530 ms)
        // int len = s.Length;
        // for (int i = 0; i < len / 2; i++) {
        //     (s[i], s[len-i-1]) = (s[len-i-1], s[i]);
        // }
        // solution #2 (276 ms)
        int start = 0, end = s.Length - 1;
        while (start < end)
        {
            var temp = s[start];
            s[start] = s[end];
            s[end] = temp;
            end--;
            start++;
        }
    }
}