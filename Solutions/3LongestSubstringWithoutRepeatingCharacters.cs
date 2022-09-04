using System.Collections;

namespace LeetCode.Solutions;

public class LongestSubstringWithoutRepeatingCharacters {
    //https://leetcode.com/problems/longest-substring-without-repeating-characters/
    public int LengthOfLongestSubstring(string s) {
        HashSet<object> notDuplicate = new HashSet<object>();
        Queue answerList = new Queue();
        int maxLength = 0;
        for(int i = 0;i < s.Length;i++){
            if(notDuplicate.Contains(s[i])){
                while(answerList.Count > 0 && notDuplicate.Contains(s[i])){
                    var duplicated = answerList.Dequeue();
                    notDuplicate.Remove(duplicated);
                }
            }
            notDuplicate.Add(s[i]);
            answerList.Enqueue(s[i]);
            int currentLength = answerList.Count;
            maxLength = currentLength > maxLength ? currentLength : maxLength;
        }
        return maxLength;
    }
}