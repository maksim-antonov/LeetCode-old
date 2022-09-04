namespace LeetCode.Solutions;

public class LongestPalindromicSubstring
{
    // 5. Longest Palindromic Substring https://leetcode.com/problems/longest-palindromic-substring/
    
    public string LongestPalindrome(string s)
    {
        if (s.Length <= 1)
        {
            return s;
        }
        
        var start = 0;
        var length = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var evenLength = Palindrome(s, i, i+1);

            var oddLength = Palindrome(s, i, i);

            var len = Math.Max(evenLength, oddLength);

            if (len > length)
            {
                length = len;
                start = i - (length - 1) / 2;
            }
        }

        return s.Substring(start, length);
    }

    public int Palindrome(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return right - left - 1;
    }
}