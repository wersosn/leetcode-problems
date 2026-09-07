// Pattern: Binary Search
// When to use: Searching for the integer square root of a non-negative integer, finding the largest integer whose square is less than or equal to x
// Complexity: O(log n) time, O(1) space

public class Solution {
    public int MySqrt(int x) {
        if(x == 1) {
            return 1;
        }

        int left = 0, right = x, result = 0;
        while(left < right) {
            int middle = left + (right - left) / 2;
            if(middle <= x / middle) { // b*b <= x -> b <= x/b
                result = middle;
                left = middle + 1;
            }
            else {
                right = middle;
            }
        }
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
        var result1 = solution.MySqrt(4);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.MySqrt(8);
        Console.WriteLine("Result for case 2: " + result2);
    }
}