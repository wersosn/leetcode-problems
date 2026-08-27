// Pattern: Two pointers with left/right maximum heights.
// When to use: When processing a sequence from both ends while tracking boundary values.
// Complexity: O(n) time and O(1) extra space.

public class Solution {
    public int Trap(int[] height) {
        int maxTrap = 0;
        int left = 0, right = height.Length - 1;
        int leftMax = 0, rightMax = 0;

        while(left < right) {
            if(height[left] < height[right]) {
                if(height[left] >= leftMax) {
                    leftMax = height[left];
                }
                else {
                    maxTrap += leftMax - height[left];
                }
                left++;
            }
            else {
                if(height[right] >= rightMax) {
                    rightMax = height[right];
                }
                else {
                    maxTrap += rightMax - height[right];
                }
                right--;
            }
        }
        return maxTrap;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.Trap([0,1,0,2,1,0,1,3,2,1,2,1]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.Trap([4,2,0,3,2,5]);
        Console.WriteLine("Result for case 2: " + result2);
    }
}