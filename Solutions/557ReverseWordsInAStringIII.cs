using System.Text;

namespace LeetCode.Solutions;

public class ReverseWordsInAStringIII
{
    //https://leetcode.com/problems/reverse-words-in-a-string-iii/\
    public string ReverseWords(string s)
    {
        int p1 = 0;
        StringBuilder sb = new StringBuilder(s);

        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] == ' ')
            {
                ReverseSingleWord(sb, p1, i - 1);
                p1 = i + 1;
            }
            else if (i == sb.Length - 1) //end of string, since there is no space at the end
            {
                ReverseSingleWord(sb, p1, i);
            }
        }

        return sb.ToString();


//         Solution #1 not so fast
//         string[] words = s.Split(' ');

//         for (int i = 0; i < words.Length; i++) {
//             char[] word = words[i].ToCharArray();
//             int start = 0, end = word.Length - 1;
//             while (start < end)
//             {
//                 var temp = word[start];
//                 word[start] = word[end];
//                 word[end] = temp;
//                 end--;
//                 start++;
//             }

//             words[i] = string.Join("",word);
//         }

//         return string.Join(" ", words);
    }

    // for second solution
    private void ReverseSingleWord(StringBuilder s, int start, int end)
    {
        while (start < end)
        {
            char temp = s[start];
            s[start] = s[end];
            s[end] = temp;

            start++;
            end--;
        }
    }
}