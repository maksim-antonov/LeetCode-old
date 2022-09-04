namespace LeetCode.Solutions;

public class ReverseInteger {
    //https://leetcode.com/problems/reverse-integer/
    public int Reverse(int x) {
        string str;
        bool isNegative;

        if (x < 0) {
            str = x.ToString().Substring(1);
            isNegative = true;
        }
        else {
            str = x.ToString();
            isNegative = false;
        }

        var outNum = 0;
        var strs = str.ToArray();
        for (var i = 0; i < strs.Length / 2; i++) {
            var temp = strs[strs.Length - (1 + i)];
            strs[strs.Length - 1 - i] = strs[i];
            strs[i] = temp;
        }

        str = string.Join("", strs);

        if (isNegative) 
            str = "-" + str;

        if (int.TryParse(str, out var num)) {
            return num;
        }
        else {
            return 0;
        }
        
    }
}