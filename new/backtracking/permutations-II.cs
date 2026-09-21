// Pattern: Backtracking with sorting and duplicate skipping
// When to use: When generating all unique permutations of an array containing duplicates
// Complexity: O(n * n!) time and O(n) auxiliary space, excluding the O(n * n!) output

public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        if(nums == null) {
            return result;
        }

        nums.Sort();
        List<int> combination = new List<int>();
        bool[] used = new bool[nums.Length];

        void Backtrack() {
            if(combination.Count == nums.Length) {
                result.Add(new List<int>(combination));
                return;
            }
            for(int i = 0; i < nums.Length; i++) {
                if(used[i] || i > 0 && nums[i-1] == nums[i] && !used[i-1]) {
                    continue;
                }
                combination.Add(nums[i]);
                used[i] = true;
                Backtrack();
                used[i] = false;
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
        var result1 = solution.PermuteUnique([1,1,2]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.PermuteUnique([1,2,3]);
        Console.WriteLine("Result for case 2: " + result2);
    }
}