// Pattern: Stack
// When to use: Finding the number of days you have to wait after each day to get a warmer temperature
// Complexity: O(n) time, O(n) space

public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stack = new Stack<int>();
        int[] result = new int[temperatures.Length];
        Array.Fill(result, 0);

        for(int i = 0; i < temperatures.Length; i++) {
            int current = temperatures[i];
            while(stack.Count > 0 && current > temperatures[stack.Peek()]) {
                int idx = stack.Pop();
                result[idx] = i - idx;
            }
            stack.Push(i);
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
        
        // Case 1:
        var result1 = solution.DailyTemperatures(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 });
        Console.WriteLine("Result for case 1: " + string.Join(", ", result1));

        // Case 2:
        var result2 = solution.DailyTemperatures(new int[] { 30, 40, 50, 60 });
        Console.WriteLine("Result for case 2: " + string.Join(", ", result2));

        // Case 3:
        var result3 = solution.DailyTemperatures(new int[] { 30, 60, 90 });
        Console.WriteLine("Result for case 3: " + string.Join(", ", result3));
    }
}