// Pattern: Sort and scan, skipping duplicate values.
// When to use: When ordering the input is acceptable and you need to find the longest consecutive run.
// Complexity: O(nlogn) time due to sorting and O(1) extra space (excluding the sort implementation).

public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) {
            return 0;
        }
        
        Array.Sort(nums);
        int longest = 1;
        int current = 1;

        for(int i = 1; i < nums.Length; i++) {
            if(nums[i] == nums[i-1]) {
                continue;
            }

            if(nums[i] == nums[i-1] + 1) {
                current++;
                if(current > longest) {
                    longest = current;
                }
            }
            else {
                current = 1;
            }
        }

        return longest;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.LongestConsecutive([100,4,200,1,3,2]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.LongestConsecutive([0,3,7,2,5,8,4,6,0,1]);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.LongestConsecutive([1,0,1,2]);
        Console.WriteLine("Result for case 3: " + result3);
    }
}