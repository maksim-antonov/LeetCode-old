namespace LeetCode.Solutions.Day3;

public class TwoSumII
{
    public int[] Result(int[] numbers, int target) 
    {
        var answer = new int[2];
        
        var myDict=new Dictionary<int,int>();
        
        for (var i=0; i < numbers.Length; i++){
            if (myDict.ContainsKey(target - numbers[i])) {
                answer[1]=i+1;
                answer[0]=myDict[target - numbers[i]]+1;
                break;
            }
            
            if(!myDict.ContainsKey(numbers[i])) myDict.Add(numbers[i], i);
        }
        
        return answer;
    }
}