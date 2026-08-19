// Pattern: Prefix and suffix products
// When to use: When each result depends on all elements except the current one
// Complexity: O(n) time and O(n) extra space

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];

        prefix[0] = 1;
        for(int i = 1; i < nums.Length; i++) {
            prefix[i] = prefix[i-1] * nums[i-1];
        }

        suffix[nums.Length-1] = 1;
        for(int i = nums.Length - 2; i >= 0; i--) {
            suffix[i] = suffix[i+1] * nums[i+1];
        }

        for(int i = 0; i < nums.Length; i++) {
            result[i] = prefix[i] * suffix[i];
        }
        return result;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        bool result1 = solution.ProductExceptSelf([1, 2, 3, 4]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        bool result2 = solution.ProductExceptSelf([-1, 1, 0, -3, 3]);
        Console.WriteLine("Result for case 2: " + result2);
    }
}