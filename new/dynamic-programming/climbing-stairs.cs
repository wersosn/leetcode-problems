// Pattern: Dynamic programming
// When to use: When a problem can be solved by combining solutions to smaller, overlapping subproblems
// Complexity: O(n) time and O(1) space

public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 0) {
            return 0;
        }

        int prevOneStep = 1;
        int prevTwoSteps = 1;
        for(int i = 2; i <= n; i++) {
            int current = prevOneStep + prevTwoSteps;
            prevTwoSteps = prevOneStep;
            prevOneStep = current;
        }
        return prevOneStep;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.ClimbStairs(2);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.ClimbStairs(3);
        Console.WriteLine("Result for case 2: " + result2);
    }
}