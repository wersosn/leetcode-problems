// Pattern: Binary Search
// When to use: Searching in a sorted array, finding the position of an element efficiently
// Complexity: O(log n) time, O(n) space

public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        while(left <= right) {
            int middle = left + (right - left) / 2;
            if(nums[middle] == target) {
                return middle;
            }
            else if(nums[middle] > target) {
                right = middle - 1;
            }
            else {
                left = middle + 1;
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
        var result1 = solution.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2);
        Console.WriteLine("Result for case 2: " + result2);
    }
}