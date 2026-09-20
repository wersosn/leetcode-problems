// Pattern: Backtracking
// When to use: Finding all combinations of candidates that sum to a target, when each candidate may be used multiple times
// Complexity: O(n^(target / m)) time and O(target / m) space, excluding the output, where n is candidates.Length and m is the smallest candidate

public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        if(candidates == null || target <= 0) {
            return result;
        }

        List<int> combination = new List<int>();
        void Backtrack(int start, int remaining) {
            if(remaining == 0) {
                result.Add(new List<int>(combination));
            }
            else if(remaining < 0) {
                return;
            }
            else {
                for(int i = start; i < candidates.Length; i++) {
                    combination.Add(candidates[i]);
                    Backtrack(i, remaining - candidates[i]);
                    combination.RemoveAt(combination.Count - 1);
                }
            }
        }

        Backtrack(0, target);
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
        var result1 = solution.CombinationSum([2,3,6,7], 7);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.CombinationSum([2,3,5], 8);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.CombinationSum([2], 1);
        Console.WriteLine("Result for case 3: " + result3);
    }
}