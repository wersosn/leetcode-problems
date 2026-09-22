// Pattern: Dynamic programming
// When to use: Determine whether a string can be segmented into dictionary words
// Complexity: O(n^2 * L) time and O(n) space, where n is s.Length and L is the substring lookup cost

public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        if(s == null || wordDict == null) {
            return false;
        }

        bool[] dp = new bool[s.Length + 1];
        Array.Fill(dp, false);
        dp[0] = true;
        for(int i = 1; i <= s.Length; i++) {
            for(int j = 0; j < i; j++) {
                string word = s.Substring(j, i - j);
                if(dp[j] && wordDict.Contains(word)) {
                    dp[i] = true;
                    break;
                }
            }
        }
        return dp[s.Length];
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.WordBreak("leetcode", new List<string> { "leet", "code" });
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.WordBreak("applepenapple", new List<string> { "apple", "pen" });
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.WordBreak("catsandog",  new List<string> { "cats", "dog", "sand", "and", "cat" });
        Console.WriteLine("Result for case 3: " + result3);
    }
}
