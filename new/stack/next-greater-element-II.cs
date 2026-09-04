// Pattern: Stack
// When to use: Finding the next greater element in a circular array
// Complexity: O(n) time, O(n) space

public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        if(nums.Length == 0) {
            return new int[0];
        }

        int[] result = new int[nums.Length];
        Array.Fill(result, -1);
        Stack<int> stack = new Stack<int>();

        for(int i = 0; i < 2 * nums.Length; i++) {
            int current = nums[i % nums.Length];
            while(stack.Count > 0 && current > nums[stack.Peek()]) {    
                result[stack.Pop()] = current;
            }
            if(i < nums.Length) {
                stack.Push(i);
            }
        }
        return result;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.NextGreaterElements(new int[] { 1, 2, 1 });
        Console.WriteLine("Result for case 1: " + string.Join(", ", result1));

        //Case 2:
        var result2 = solution.NextGreaterElements(new int[] { 1, 2, 3, 4, 3 });
        Console.WriteLine("Result for case 2: " + string.Join(", ", result2));
    }
}