// Pattern: Prefix sum + hash map
// When to use: When counting contiguous subarrays with a target sum, including arrays with negative numbers
// Complexity: O(n) time and O(n) space

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int count = 0, currentSum = 0;
        Dictionary<int, int> sum = new Dictionary<int, int>();
        sum[0] = 1;
        foreach(int num in nums) {
            currentSum += num;
            if(!sum.ContainsKey(currentSum)) {
                sum[currentSum] = 0;
            }

            int remaining = currentSum - k;
            if(sum.ContainsKey(remaining)) {
                count += sum[remaining];
            }   
             
            sum[currentSum]++;  
        }
        return count;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        bool result1 = solution.SubarraySum([1,1,1], 2);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        bool result2 = solution.SubarraySum([1,2,3], 3);
        Console.WriteLine("Result for case 2: " + result2);
    }
}