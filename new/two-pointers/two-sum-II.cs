// Pattern: Two pointers
// When to use: Use on a sorted array when searching for a pair with a target sum.
// Complexity: O(n) time and O(1) space

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0, right = numbers.Length - 1;
        while(left < right) {
            if(numbers[left] + numbers[right] == target) {
                return [left+1, right+1];
            }

            if(numbers[left] + numbers[right] < target) {
                left++;
            }
            else {
                right--;
            }
        }
        return [];
    }
}

// or just Two Sum solution with +1 next to indexes:
// Complexity: O(n) time and O(n) space
public class Solution {
    public int[] TwoSumOld(int[] numbers, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();
    
        for (int i = 0; i < numbers.Length; i++) 
        {
            int complement = target - numbers[i];        
            if (seen.ContainsKey(complement)) 
            {
                return [seen[complement]+1, i+1];
            }           
            seen[numbers[i]] = i;
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
        var result1 = solution.TwoSum([2,7,11,15], 9);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.TwoSum([2,3,4], 6);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.TwoSum([-1,0], -1);
        Console.WriteLine("Result for case 3: " + result3);
    }
}