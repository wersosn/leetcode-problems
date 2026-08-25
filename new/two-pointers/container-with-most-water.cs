// Pattern: Two pointers
// When to use: When finding the maximum area between two boundaries in a linear array.
// Complexity: O(n) time, O(1) space

public class Solution {
    public int MaxArea(int[] height) {
        int maxWater = 0;
        int left = 0, right = height.Length - 1;

        while(left < right) {
            int width = right - left;
            int hig = Math.Min(height[left], height[right]);
            int result = width * hig;

            if(result > maxWater) {
                maxWater = result;
            }

            if(height[left] < height[right]) {
                left++;
            }
            else {
                right--;
            }
        }
        return maxWater;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.MaxArea([1,8,6,2,5,4,8,3,7]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.MaxArea([1,1]);
        Console.WriteLine("Result for case 2: " + result2);
    }
}