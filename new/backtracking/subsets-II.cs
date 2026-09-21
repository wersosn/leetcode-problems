// Pattern: Backtracking
// When to use: To generate all subsets while avoiding duplicate subsets when the input contains duplicates
// Complexity: O(n * 2^n) time and O(n) auxiliary space, excluding the output

public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        if(nums == null) {
            return result;
        }
        nums.Sort();
        List<int> subset = new List<int>();
        void Backtrack(int start) {
            result.Add(new List<int>(subset));
            for(int i = start; i < nums.Length; i++) {
                if(i > start && nums[i-1] == nums[i]) {
                    continue;
                }
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
        var result1 = solution.SubsetsWithDup([1,2,2]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.SubsetsWithDup([0]);
        Console.WriteLine("Result for case 2: " + result2);
    }
}