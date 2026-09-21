// Pattern: Dynamic programming
// When to use: When choices have overlapping subproblems and adjacent choices cannot both be selected
// Complexity: O(n) time and O(1) space

public class Solution {
    public int Rob(int[] nums) {
        if(nums == null || nums.Length == 0) {
            return 0;
        }

        int sumPrevHouse = 0, sumPrevHouse2 = 0;
        foreach(int n in nums) {
            int current = Math.Max(sumPrevHouse, sumPrevHouse2 + n);
            sumPrevHouse2 = sumPrevHouse;
            sumPrevHouse = current;
        }

        return sumPrevHouse;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.Rob([1,2,3,1]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.Rob([2,7,9,3,1]);
        Console.WriteLine("Result for case 2: " + result2);
    }
}