using LeetCode.Solutions;

Console.WriteLine("Welcome, this is my (Maksim Antonov) app with LeetCode problem solutions.\tIf you want to quit, than write Q and press Enter.");

start:

Console.WriteLine("Available options:");
Console.WriteLine("1. Two Sum (Easy)");
Console.WriteLine("4. Median of Two Sorted Arrays (Hard)");
Console.WriteLine("9. Palindrome Number (Easy)");
Console.WriteLine("13. Roman to Integer (Easy level)");
Console.WriteLine("14. Longest Common Prefix (Easy level)");

var val = Console.ReadLine();

while (string.IsNullOrWhiteSpace(val))
{
    val = Console.ReadLine();
}

switch (val)
{
    case "1":
        Console.WriteLine("Two Sum (Easy level) selected. https://leetcode.com/problems/two-sum/");
        Console.WriteLine($"Indexes of two numbers that will sum 9: {string.Join(", ", TwoSum.Result(new [] {2,7,11,15}, 9))}");
        goto start;
    case "4":
        Console.WriteLine("Median of Two Sorted Arrays (Hard level) selected. https://leetcode.com/problems/median-of-two-sorted-arrays/");
medianSortedStart:
        Console.Write("Input first array using space as a separator or write Q to quit: ");
        var firstArrStr = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(firstArrStr))
        {
            Console.WriteLine("Incorrect input.");
            goto medianSortedStart;
        }
        
        if (firstArrStr is "Q" or "q")
            goto start;

        var numberStrings1 = firstArrStr.Split(' ').ToArray();
        var firstList = new List<int>(); 
        
        foreach (var n in numberStrings1)
        {
            if (int.TryParse(n, out int num))
            {
                firstList.Add(num);
            }
            else
            {
                Console.WriteLine("Incorrect input.");
                goto medianSortedStart;
            }
        }

        Console.Write("Now input second array using space as a separator or write Q to quit: ");
        var secondArrStr = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(secondArrStr))
        {
            Console.WriteLine("Incorrect input.");
            goto medianSortedStart;
        }
        
        if (secondArrStr is "Q" or "q")
            goto start;

        var numberStrings2 = secondArrStr.Split(' ').ToArray();
        var secondList = new List<int>(); 
        
        foreach (var n in numberStrings2)
        {
            if (int.TryParse(n, out int num))
            {
                secondList.Add(num);
            }
            else
            {
                Console.WriteLine("Incorrect input.");
                goto medianSortedStart;
            }
        }

        int[] firstArr = firstList.ToArray();
        Array.Sort(firstArr);
        
        int[] secondArr = secondList.ToArray();
        Array.Sort(secondArr);

        var median = MedianOfTwoSortedArrays.FindMedianSortedArrays(firstArr, secondArr);

        Console.WriteLine($"Two sorted arrays: [{string.Join(", ", firstArr)}], [{string.Join(", ", secondArr)}]");
        Console.WriteLine($"Median of two sorted arrays: {median}");

        goto start;
    case "9":
        Console.WriteLine("Palindrome Number (Easy level) selected. https://leetcode.com/problems/palindrome-number/");
palindromeStart:
        Console.WriteLine("Please write the number. \tIf you want quit write Q and press Enter.");
        var checkString = Console.ReadLine();
        Console.WriteLine();
        int checkNumber;
        if (!string.IsNullOrWhiteSpace(checkString))
        {
            if (checkString is "q" or "Q")
                goto start;

            if (int.TryParse(checkString, out checkNumber))
            {
                var str = PalindromeNumber.IsPalindrome(checkNumber) ? "Palindrome" : "not Palindrome";
                Console.WriteLine($"Number {checkNumber} is {str}");
                goto palindromeStart;
            }
        }
        Console.WriteLine("Invalid input. Needs integer.");
        goto palindromeStart;
    case "13":
        Console.WriteLine("Roman to Integer (Easy level) selected. https://leetcode.com/problems/roman-to-integer/");
romanStart:
        Console.WriteLine("Please write Roman number. \tIf you want to quit write Q and press Enter.");
        var checkRString = Console.ReadLine();
        Console.WriteLine();
        if (!string.IsNullOrWhiteSpace(checkRString))
        {
            if (checkRString is "q" or "Q")
                goto start;

            var int32 = RomanToInteger.RomanToInt(checkRString.ToUpper());

            if (int32 == 0)
            {
                Console.WriteLine("Invalid input. Needs Roman number.");
                goto romanStart;
            }

            Console.WriteLine(checkRString.ToUpper() + " is " + int32);
        }
        Console.WriteLine("Invalid input. Needs Roman number.");
        goto romanStart;
        
    case "14":
        Console.WriteLine("Longest Common Prefix (Easy level) selected. https://leetcode.com/problems/longest-common-prefix/");
lcpStart:
        Console.Write("Input strings using space as a separator or write Q to quit: ");
        var lcpStr = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(lcpStr))
        {
            Console.WriteLine("Incorrect input.");
            goto lcpStart;
        }
        
        if (lcpStr is "Q" or "q")
            goto start;

        var strings = lcpStr.Split(' ').ToArray();
        
        var ans = LongestCommonPrefix.Result(strings);
 
        if (ans.Length > 0)
        {
            Console.WriteLine("The longest common " +
                          "prefix is - " + ans);
        }
        else
        {
            Console.WriteLine("There is no common prefix");
        }
        goto start;
    case "q" or "Q":
        Console.WriteLine("Bye!");
        break;
    default:
        Console.WriteLine("Wrong input. There is no task with this code number yet.");
        goto start;
}