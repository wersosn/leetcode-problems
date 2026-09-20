// Pattern: Backtracking
// When to use: Generate all possible combinations of a fixed size from a set of choices
// Complexity: O(C(n, k) * k) time and O(k) auxiliary space, excluding the output

public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        IList<IList<int>> result = new List<IList<int>>();
        if(n <= 0 || k <= 0) {
            return result;
        }

        List<int> combination = new List<int>();
        void Backtrack(int start) {
            if(combination.Count == k) {
                result.Add(new List<int>(combination));
                return;
            }
            for(int i = start; i <= n; i++) {
                combination.Add(i);
                Backtrack(i + 1);
                combination.RemoveAt(combination.Count - 1);
            }
        }

        Backtrack(1);
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
        var result1 = solution.Combine(4,2);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.Combine(1,1);
        Console.WriteLine("Result for case 2: " + result2);
    }
}
