// Pattern: Hashmap for tracking "what I've seen so far"
// When to use: When you need to find two numbers in an array that are the same (i.e., duplicates).
// Complexity: O(n) time, O(n) space.

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> twice = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++) {
            if(twice.Contains(nums[i])) {
                return true;
            }
            twice.Add(nums[i]);
        }
        return false;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        int[] nums1 = { 1, 2, 3, 1};
        bool result1 = solution.ContainsDuplicate(nums1);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        int[] nums2 = { 1, 2, 3, 4 };
        bool result2 = solution.ContainsDuplicate(nums2);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
        bool result3 = solution.ContainsDuplicate(nums3);
        Console.WriteLine("Result for case 3: " + result3);
    }
}