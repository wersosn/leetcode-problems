// Pattern: Sliding Window
// When to use: Find the longest contiguous subarray containing at most k zeros (or ones) by flipping them
// Complexity:] O(n) time and O(1) space (the window stores at most k zeros)

public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int left = 0;
        int zeros = 0;
        int maxConsecutive = 0;

        for(int right = 0; right < nums.Length; right++) {
            if(nums[right] == 0) {
                zeros++;
            }

            while(zeros > k) {
                if(nums[left] == 0) {
                    zeros--;
                }
                left++;
            }

            maxConsecutive = Math.Max(maxConsecutive, right - left + 1);
        }
        return maxConsecutive;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.LongestOnes(new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.LongestOnes(new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0 }, 3);
        Console.WriteLine("Result for case 2: " + result2);
    }
}