// Pattern: Binary Search
// When to use: Searching in a rotated sorted array, finding the position of an element efficiently
// Complexity: O(log n) time, O(1) space

public class Solution {
    public int FindMin(int[] nums) {
        int left = 0, right = nums.Length - 1;
        
        while(left < right) {
            int middle = left + (right - left) / 2;
            if(nums[middle] > nums[right]) {
                left = middle + 1;
            }
            else if(nums[middle] <= nums[right]) {
                right = middle;
            }
        }
        return nums[left];
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.FindMin(new int[] { 3, 4, 5, 1, 2 });
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.FindMin(new int[] { 4, 5, 6, 7, 0, 1, 2 });
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.FindMin(new int[] { 11, 13, 15, 17 });
        Console.WriteLine("Result for case 3: " + result3);
    }
}