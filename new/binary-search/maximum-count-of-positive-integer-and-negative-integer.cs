// Pattern: Binary Search
// When to use: Counting the number of positive and negative integers in a sorted array, finding the maximum count efficiently
// Complexity: O(log n) time, O(1) space

public class Solution {
    public int MaximumCount(int[] nums) {
        // Negative count:
        int left = 0, right = nums.Length - 1;
        while (left <= right) {
            int middle = left + (right - left) / 2;
            if(nums[middle] >= 0) {
                right = middle - 1;
            }
            else if(nums[middle] < 0) {
                left = middle + 1;
            }
        }
        int negative = left;

        // Positive count:
        left = 0;
        right = nums.Length - 1;
        while (left <= right) {
            int middle = left + (right - left) / 2;
            if(nums[middle] <= 0) {
                left = middle + 1;
            }
            else if(nums[middle] > 0) {
                right = middle - 1;
            }
        }
        int positive = nums.Length - left;

        // Result:
        return Math.Max(positive, negative);
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.MaximumCount(new int[] { -2, -1, -1, 1, 2, 3 });
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.MaximumCount(new int[] { -3, -2, -1, 0, 0, 1, 2 });
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.MaximumCount(new int[] { 5, 20, 66, 1314 });
        Console.WriteLine("Result for case 3: " + result3);
    }
}