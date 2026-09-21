// 1.
// Pattern: Backtracking with memoization (top-down dynamic programming)
// When to use: When recursive choices revisit the same state, such as (index, current sum)
// Complexity: O(n * S) time and O(n * S) space, where S is the number of reachable sums
public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
        if(nums == null || nums.Length == 0) {
            return 0;
        }

        Dictionary<(int idx, int sum), int> memo = new Dictionary<(int idx, int sum), int>();

        int Backtrack(int idx, int sum) {
            if(idx == nums.Length) {
                if(sum == target) {
                    return 1;
                }
                else {
                    return 0;
                }
            }

            if(memo.ContainsKey((idx, sum)))
            {
                return memo[(idx, sum)];
            }
            
            int ways = Backtrack(idx + 1, sum + nums[idx]) + Backtrack(idx + 1, sum - nums[idx]);
            memo[(idx, sum)] = ways;
            return ways;
        }
        
        return Backtrack(0,0);
    }
}

// 2.
// Pattern: Plain backtracking (depth-first search)
// When to use: For small input sizes or when you need to enumerate all possible choices
// Complexity: O(2^n) time and O(n) space for the recursion stack

public class Solution {
    public int FindTargetSumWays2(int[] nums, int target) {
        if(nums == null || nums.Length == 0) {
            return 0;
        }

        int expressions = 0;
        
        void Backtrack(int idx, int sum) {
            if(idx == nums.Length) {
                if(sum == target) {
                    expressions++;
                }
                return;
            }
            Backtrack(idx + 1, sum + nums[idx]);
            Backtrack(idx + 1, sum - nums[idx]);
        }

        Backtrack(0,0);
        return expressions;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.FindTargetSumWays([1,1,1,1,1], 3);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.FindTargetSumWays([1], 1);
        Console.WriteLine("Result for case 2: " + result2);
    }
}