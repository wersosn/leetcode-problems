// Pattern: Dynamic programming
// When to use: When finding the minimum number of coins needed to make a target amount with unlimited coin reuse
// Complexity: O(amount * coins.Length) time and O(amount) space

public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(coins == null || amount < 0) {
            return -1;
        }

        int[] dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);
        dp[0] = 0;
        for(int i = 1; i <= amount; i++) {
            foreach(int coin in coins) {
                if(coin <= i) {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }
        if(dp[amount] == amount + 1) {
            return -1;
        }
        return dp[amount];
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.CoinChange([1,2,5], 11);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.CoinChange([2], 3);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.CoinChange([1], 0);
        Console.WriteLine("Result for case 3: " + result3);
    }
}
