// Pattern: Two Pointers (in-place deduplication)
// When to use: When the array is sorted and you need to remove duplicates while keeping the first occurrence of each value in order
// Complexity: O(n) time and O(1) space

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int left = 1;
        for(int right = 1; right < nums.Length; right++) {
            if(nums[right] != nums[left - 1]) {
                nums[left] = nums[right];
                left++;
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
        var result1 = solution.RemoveDuplicates([1,1,2]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.RemoveDuplicates([0,0,1,1,1,2,2,3,3,4]);
        Console.WriteLine("Result for case 2: " + result2);
    }
}