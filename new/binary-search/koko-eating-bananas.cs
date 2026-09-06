// Pattern: Binary Search
// When to use: Finding the minimum eating speed to finish all banana piles within h hours
// Complexity: O(n log m) time, where n is the number of piles and m is the maximum pile size, O(1) space

public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1, right = piles.Max();

        while(left < right) {
            int middle = left + (right - left) / 2;
            int hours = 0;
            foreach(int pile in piles) {
                hours += (pile + middle - 1) / middle;
            }

            if(hours > h) {
                left = middle + 1;
            }
            else {
                right = middle;
            }
        }
        
        int k = left;
        return k;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.MinEatingSpeed(new int[] { 3, 6, 7, 11 }, 8);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.MinEatingSpeed(new int[] { 30, 11, 23, 4, 20 }, 5);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.MinEatingSpeed(new int[] { 30, 11, 23, 4, 20 }, 6);
        Console.WriteLine("Result for case 3: " + result3);
    }
}