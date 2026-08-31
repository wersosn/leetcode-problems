// Pattern: Sliding window
// When to use: Finding minimum/maximum contiguous subarray meeting a condition
// Complexity: O(n) time, O(1) space

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0, sum = 0;
        int minLength =  int.MaxValue;

        for(int right = 0; right < nums.Length; right++) {
            sum += nums[right];
            while(sum >= target) {
                int currentLength = right - left + 1;
                if(currentLength < minLength) {
                    minLength = currentLength;
                }
                sum -= nums[left];
                left++;
            }
        }

        if(minLength == int.MaxValue) {
            return 0;
        }
        return minLength;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.MinSubArrayLen(7, [2,3,1,2,4,3]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.MinSubArrayLen(4, [1,4,4]);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.MinSubArrayLen(11, [1,1,1,1,1,1,1,1]);
        Console.WriteLine("Result for case 3: " + result3);
    }
}