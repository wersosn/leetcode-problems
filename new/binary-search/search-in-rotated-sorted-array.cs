// Pattern: Binary Search
// When to use: Searching in a rotated sorted array, finding the position of an element efficiently
// Complexity: O(log n) time, O(n) space

public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        while(left <= right) {
            int middle = left + (right - left) / 2;
            if(nums[middle] == target) {
                return middle;
            }

            if(nums[left] <= nums[middle]) {
                if(nums[left] <= target && target < nums[middle]) {
                    left = middle + 1;
                }
                else {
                    right = middle - 1;
                }
            }
            else {
                if(nums[right] >= target && target > nums[middle]) {
                    right = middle + 1;
                }
                else {
                    left = middle - 1;
                }
            }
        }
        return -1;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.Search(new int[] { 1 }, 0);
        Console.WriteLine("Result for case 3: " + result3);
    }
}