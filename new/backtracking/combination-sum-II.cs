// Pattern: Backtracking
// When to use: Find unique combinations that reach a target, using each candidate at most once
// Complexity: O(n log n + 2^n) time, O(n) auxiliary space (excluding the output)

public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        if(candidates == null || target <= 0) {
            return result;
        }

        List<int> combination = new List<int>();
        candidates.Sort();
        void Backtrack(int start, int remaining) {
            if(remaining == 0) {
                result.Add(new List<int>(combination));
            }
            else if(remaining < 0) {
                return;
            }
            else {      
                for(int i = start; i < candidates.Length; i++) {
                    if(i > start && candidates[i-1] == candidates[i]) {
                        continue;
                    }
                    combination.Add(candidates[i]);
                    Backtrack(i + 1, remaining - candidates[i]);
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
        var result1 = solution.CombinationSum2([10,1,2,7,6,1,5], 8);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.CombinationSum2([2,5,2,1,2], 5);
        Console.WriteLine("Result for case 2: " + result2);
    }
}