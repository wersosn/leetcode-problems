// Pattern: Stack
// When to use: Finding the next greater element in a sequence, maintaining a monotonic stack
// Complexity: O(n) time, O(n) space

public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        if(nums1.Length == 0) {
            return new int[0];
        }

        int[] result = new int[nums1.Length];
        Stack<int> stack = new Stack<int>();
        Dictionary<int, int> nextGreater = new Dictionary<int, int>();

        foreach(int current in nums2) {
            while(stack.Count > 0 && current > stack.Peek()) {    
                nextGreater[stack.Pop()] = current;
            }
            stack.Push(current);
        }

        while(stack.Count > 0) {
            nextGreater[stack.Pop()] = -1;
        }

        for(int i = 0; i < nums1.Length; i++) {
            result[i] = nextGreater[nums1[i]];
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
        var result1 = solution.NextGreaterElement(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 });
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.NextGreaterElement(new int[] { 2, 4 }, new int[] { 1, 2, 3, 4 });
        Console.WriteLine("Result for case 2: " + result2);
    }
}