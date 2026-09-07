// Pattern: Binary Search
// When to use: Splitting an array into k subarrays such that the largest sum of any subarray is minimized
// Complexity: O(n log m) time, O(1) space, where n is the number of elements in the array and m is the range of possible sums

public class Solution {
    public int SplitArray(int[] nums, int k) {
        int left = nums.Max(), right = nums.Sum();
        while(left < right) {
            int middle = left + (right - left) / 2;
            int subarrays = 1;
            int currentSum = 0;
            
            foreach(int n in nums) {
                int sum = currentSum + n;
                if(sum > middle) {
                    subarrays++;
                    currentSum = n;
                }
                else {
                    currentSum += n;
                }
            }
            
            if(subarrays > k) {
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
        var result1 = solution.SplitArray(new int[] { 7, 2, 5, 10, 8 }, 2);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.SplitArray(new int[] { 1, 2, 3, 4, 5 }, 2);
        Console.WriteLine("Result for case 2: " + result2);
    }
}