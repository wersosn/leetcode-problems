// Pattern: Binary Search
// When to use: Find a peak element in an array
// Complexity: O(log n) time, O(1) space

public class Solution {
    public int FindPeakElement(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        while(left < right) {
            int middle = left + (right - left) / 2;
            if(nums[middle] < nums[middle + 1]) {
                left = middle + 1;
            }
            else {
                right = middle;
            }
        }
        return left;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.FindPeakElement(new int[] {1, 2, 3, 1});
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.FindPeakElement(new int[] {1, 2, 1, 3, 5, 6, 4});
        Console.WriteLine("Result for case 2: " + result2);
    }
}