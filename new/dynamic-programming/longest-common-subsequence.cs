// Pattern: Dynamic programming
// When to use: When finding the longest sequence that appears in both strings in the same order, without requiring the characters to be contiguous
// Complexity: O(m * n) time and O(m * n) space, where m and n are string lengths

public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        if(text1 == null || text2 == null) {
            return 0;
        }

        int[,] dp = new int[text1.Length + 1, text2.Length + 1];
        for(int i = 0; i < text1.Length; i++)
        {
            dp[i, 0] = 0;
        }

        for(int j = 0; j < text2.Length; j++)
        {
            dp[0, j] = 0;
        }

        for(int i = 1; i <= text1.Length; i++) {
            for(int j = 1; j <= text2.Length; j++) {
                if(text1[i - 1] == text2[j - 1]) {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        return dp[text1.Length, text2.Length];
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.LongestCommonSubsequence("abcde", "ace");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.LongestCommonSubsequence("abc", "abc");
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.LongestCommonSubsequence("abc", "def");
        Console.WriteLine("Result for case 3: " + result3);
    }
}