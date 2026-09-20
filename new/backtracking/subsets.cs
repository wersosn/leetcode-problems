// Pattern: Backtracking
// When to use: Generate all possible subsets (the power set) of a collection
// Complexity: O(n * 2^n) time and O(n) auxiliary space, excluding the output

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        if(nums == null) {
            return result;
        }

        List<int> subset = new List<int>();
        void Backtrack(int start) {
            result.Add(new List<int>(subset));
            for(int i = start; i < nums.Length; i++) {
                subset.Add(nums[i]);
                Backtrack(i + 1);
                subset.RemoveAt(subset.Count - 1);
            }
        }
        Backtrack(0);
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
        var result1 = solution.Subsets([1,2,3]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.Subsets([0]);
        Console.WriteLine("Result for case 2: " + result2);
    }
}