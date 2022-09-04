namespace LeetCode.Solutions;

public class IntegerToRoman
{
    //https://leetcode.com/problems/integer-to-roman/
    public string IntToRoman(int num)
    {
        int[] values =
        {
            1000,
            900, 500, 400, 100,
            90, 50, 40, 10,
            9, 5, 4, 1,
        };

        string[] units =
        {
            "M",
            "CM", "D", "CD", "C",
            "XC", "L", "XL", "X",
            "IX", "V", "IV", "I",
        };
        string res = "";
        for (int i = 0; i < 13; i++)
            while (num >= values[i])
            {
                res += units[i];
                num -= values[i];
            }

        return res;
//         String[] Thousands={"","M","MM","MMM"};
// String[] Hundreds={"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};
// String[] Tens={"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"};
// String[] Units={"","I","II","III","IV","V","VI","VII","VIII","IX"};
// return Thousands[num/1000]+Hundreds[(num%1000)/100]+Tens[(num%100)/10]+Units[(num%10)];
    }
}