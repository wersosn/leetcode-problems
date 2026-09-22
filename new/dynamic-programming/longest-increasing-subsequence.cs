// Pattern: Dynamic programming
// When to use: Find the length of the longest strictly increasing subsequence
// Complexity: O(n^2) time and O(n) space

public class Solution {
    public int LengthOfLIS(int[] nums) {
        if(nums == null) {
            return 0;
        }

        int[] dp = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++) {
            dp[i] = 1;
            for(int j = 0; j < i; j++) {
                if(nums[j] < nums[i]) {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }

        return dp.Max();
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.LengthOfLIS([10,9,2,5,3,7,101,18]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.LengthOfLIS([0,1,0,3,2,3]);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.LengthOfLIS([7,7,7,7,7,7,7]);
        Console.WriteLine("Result for case 3: " + result3);
    }
}
