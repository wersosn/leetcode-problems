// Pattern: Stack
// When to use: Finding the largest rectangle in a histogram, using a stack to keep track of the indices of the bars
// Complexity: O(n) time, O(n) space

public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int largestRectangle = 0;
        Stack<int> stack = new Stack<int>();

        for(int i = 0; i <= heights.Length; i++) {
            int currentHeight = 0;
            if(i < heights.Length) {
                currentHeight = heights[i];
            }

            while(stack.Count > 0 && heights[stack.Peek()] > currentHeight) {
                int height = heights[stack.Pop()];
                int width = 0;

                if(stack.Count == 0) {
                    width = i;
                }
                else {
                    width = i - stack.Peek() - 1;
                }
                largestRectangle = Math.Max(largestRectangle, height * width);
            }

            stack.Push(i);
        }
        return largestRectangle;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.LargestRectangleArea(new int[] { 2, 1, 5, 6, 2, 3 });
        Console.WriteLine("Result for case 1: " + string.Join(", ", result1));

        //Case 2:
        var result2 = solution.LargestRectangleArea(new int[] { 2, 4 });
        Console.WriteLine("Result for case 2: " + string.Join(", ", result2));
    }
}