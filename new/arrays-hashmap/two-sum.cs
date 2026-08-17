<<<<<<< HEAD
// Pattern: Hashmap for tracking "what I've seen so far"
// When to use: for each element, I'm looking for something related to another element
=======
// Pattern: Dictionary for tracking "what I've seen so far"
// When to use: When you need to find two numbers in an array that add up to a specific target.
>>>>>>> 4dc9125d1cd87f5c3d9f75252f6f262a051a5111
// Complexity: O(n) time, O(n) space.

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();
    
        for (int i = 0; i < nums.Length; i++) 
        {
            int complement = target - nums[i];        
            if (seen.ContainsKey(complement)) 
            {
                return [seen[complement], i];
            }           
            seen[nums[i]] = i;
        }    
        return null;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        //Case 1:
        int[] nums1 = { 2, 7, 11, 15 };
        int target1 = 9;
        int[] result1 = solution.TwoSum(nums1, target1);
        Console.WriteLine("Result for case 1: [" + result1[0] + "," + result1[1] + "]");

        //Case 2:
        int[] nums2 = { 3, 2, 4 };
        int target2 = 6;
        int[] result2 = solution.TwoSum(nums2, target2);
        Console.WriteLine("Result for case 2: [" + result2[0] + "," + result2[1] + "]");

        //Case 3:
        int[] nums3 = { 3, 3 };
        int target3 = 6;
        int[] result3 = solution.TwoSum(nums3, target3);
        Console.WriteLine("Result for case 3: [" + result3[0] + "," + result3[1] + "]");
    }
}