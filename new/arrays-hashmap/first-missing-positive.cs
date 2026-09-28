// Pattern: In-place cyclic sort (place each positive value x at index x - 1)
// When to use: When finding a missing value in the range 1..n with O(1) extra space
// Complexity: O(n) time and O(1) extra space

public class Solution {
    public int FirstMissingPositive(int[] nums) {
        for(int i = 0; i < nums.Length; i++) {
            while(nums[i] >= 1 && nums[i] <= nums.Length && nums[i] != nums[nums[i] - 1]) {
                int correctIndex = nums[i] - 1;
                if(nums[correctIndex] == nums[i]) {
                    break;
                }

                int tmp = nums[i];
                nums[i] = nums[correctIndex];
                nums[correctIndex] = tmp;
            }
        }

        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] != i + 1) {
                return i + 1;
            }
        }

        return nums.Length + 1;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        bool result1 = solution.FirstMissingPositive([1,2,0]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        bool result2 = solution.FirstMissingPositive([3,4,-1,1]);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        bool result3 = solution.FirstMissingPositive([7,8,9,11,12]);
        Console.WriteLine("Result for case 3: " + result3);
    }
}