namespace LeetCode.Solutions;

public class PermutatinInString {
    //https://leetcode.com/problems/permutation-in-string/
    public bool CheckInclusion(string s1, string s2) {
        s1 = Sort(s1);
        for (int i = 0; i <= s2.Length - s1.Length; i++) {
            if (s1.Equals(Sort(s2.Substring(i, s1.Length))))
                return true;
        }
        return false;
    }
    
    public string Sort(string s) {
        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}