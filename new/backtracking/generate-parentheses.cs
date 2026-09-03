// Pattern: Backtracking
// When to use: Explore all possible combinations and backtrack when a solution is not valid
// Complexity: O(4^n / sqrt(n)) - Catalan number

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        if(n == 0) {
            return new List<string>();
        }

        List<string> result = new();

        void Backtrack(string current, int open, int close) {
            if(open == n && close == n) {
                result.Add(current);
            }

            if(open < n) {
                Backtrack(current + "(", open + 1, close);
            }

            if(close < open) {
                Backtrack(current + ")", open, close + 1);
            }
        }

        Backtrack("", 0, 0);
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
        var result1 = solution.GenerateParenthesis(3);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.GenerateParenthesis(1);
        Console.WriteLine("Result for case 2: " + result2);
    }
}