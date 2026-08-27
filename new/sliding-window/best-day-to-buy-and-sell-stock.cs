// Pattern: Sliding window / one-pass greedy
// When to use: When finding the maximum profit from one buy followed by one sell.
// Complexity: O(n) time and O(1) space

public class Solution {
    public int MaxProfit(int[] prices) {
        int buyPrice = prices[0];
        int maxProfit = 0;

        for(int i = 1; i < prices.Length; i++) {
            int profit = prices[i] - buyPrice;
            maxProfit = Math.Max(maxProfit, profit);
            if(prices[i] < buyPrice) {
                buyPrice = prices[i];
            }
        }
        return maxProfit;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.MaxProfit([7,1,5,3,6,4]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.MaxProfit([7,6,4,3,1]);
        Console.WriteLine("Result for case 2: " + result2);
    }
}