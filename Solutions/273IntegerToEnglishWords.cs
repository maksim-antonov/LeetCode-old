namespace LeetCode.Solutions;

public class IntegerToEnglishWords {
    //https://leetcode.com/problems/integer-to-english-words/
    string[] tens = {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
    string[] ones = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
        "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
    
    public string NumberToWords(int num) 
    {
        if (num == 0)
            return "Zero";
        
        return Helper(num).Trim();
    }
    
    private string Helper(int num) {
        
        if (num >= 1000000000) return (Helper(num / 1000000000) + " Billion " + Helper(num % 1000000000));
        if (num >= 1000000) return (Helper(num / 1000000) + " Million " + Helper(num % 1000000));
        if (num >= 1000) return (Helper(num / 1000) + " Thousand " + Helper(num % 1000));
        if (num >= 100) return (Helper(num / 100) + " Hundred " + Helper((num % 100))).Trim();
        if (num >= 20) return (tens[num / 10] + " " + Helper(num % 10)).Trim();
        return ones[num];
    }
}