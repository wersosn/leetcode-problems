// Pattern: Backtracking (choose an unused element, recurse, then undo the choice)
// When to use: When generating all possible arrangements or combinations of choices
// Complexity: O(n * n!) time with Contains; O(n) auxiliary space, excluding output

public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        if(nums == null) {
            return result;
        }

        List<int> combination = new List<int>();

        void Backtrack() {
            if(combination.Count == nums.Length) {
                result.Add(new List<int>(combination));
                return;
            }
            for(int i = 0; i < nums.Length; i++) {
                if(combination.Contains(nums[i])) {
                    continue;
                }
                combination.Add(nums[i]);
                Backtrack();
                combination.RemoveAt(combination.Count - 1);
            }
        }

        Backtrack();
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
        var result1 = solution.Permute([1,2,3]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.Permute([0,1]);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.Permute([1]);
        Console.WriteLine("Result for case 3: " + result3);
    }
}