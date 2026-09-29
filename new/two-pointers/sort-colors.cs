// Pattern: Two Pointers (in this case - three pointers)
// When to use: When an array contains only 3 distinct values and you need to sort it in-place with constant extra space
// Complexity: O(n) time, O(1) extra space

public class Solution {
    public void SortColors(int[] nums) {
        int left = 0, mid = 0, right = nums.Length - 1;
        while(mid <= right) {
            if(nums[mid] == 0) {
                int tmp = nums[left];
                nums[left] = nums[mid];
                nums[mid] = tmp;

                left++;
                mid++;
            }
            else if(nums[mid] == 1) {
                mid++;
            }
            else {
                int tmp = nums[mid];
                nums[mid] = nums[right];
                nums[right] = tmp;

                right--;
            }
        }
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.SortColors([2,0,2,1,1,0]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.SortColors([2,0,1]);
        Console.WriteLine("Result for case 2: " + result2);
    }
}