namespace LeetCode.Solutions;

public class TwoSum
{
    //1 two sum
    //https://leetcode.com/problems/two-sum/
    public static int[] Result(int[] nums, int target)
    {
        Console.WriteLine($"Nums: [{string.Join(", ", nums)}], Target: {target}");
        
        var answer = new int[2];
        
        var myDict=new Dictionary<int,int>();
        
        for (var i=0; i < nums.Length; i++){
            if (myDict.ContainsKey(target - nums[i])) {
                answer[1]=i;
                answer[0]=myDict[target - nums[i]];
                break;
            }
            
            if(!myDict.ContainsKey(nums[i])) myDict.Add(nums[i], i);
        }
        
        return answer;
    }
}