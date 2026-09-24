// Pattern: Dynamic programming
// When to use: When the problem has overlapping subproblems and optimal substructure, such as counting the number of ways to reach each position from previous positions
// Complexity: O(m * n) time and O(m * n) space

public class Solution {
    public int UniquePaths(int m, int n) {
        if(m <= 0 || n <= 0) {
            return 0;
        }

        int[,] dp = new int[m, n];
        for(int i = 0; i < m; i++)
        {
            dp[i, 0] = 1;
        }

        for(int j = 0; j < n; j++)
        {
            dp[0, j] = 1;
        }

        for(int row = 1; row < m; row++) {
            for(int col = 1; col < n; col++) {
                dp[row, col] = dp[row - 1, col] + dp[row, col - 1];
            }
        }
        
        return dp[m - 1, n - 1];
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.UniquePaths(3, 7);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.UniquePaths(3, 2);
        Console.WriteLine("Result for case 2: " + result2);
    }
}