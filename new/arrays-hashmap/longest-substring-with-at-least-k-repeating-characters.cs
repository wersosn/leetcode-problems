// Pattern: Divide and Conquer on invalid characters
// When to use: When a valid substring must contain every character at least k times, and splitting on characters that appear fewer than k times breaks the problem into smaller independent subproblems
// Complexity: Worst-case O(n^2) time due to repeated substring creation in recursion; O(n) auxiliary space for the frequency map and recursion stack

public class Solution {
    public int LongestSubstring(string s, int k) {
        if(s == null || k <= 0) {
            return 0;
        }

        Dictionary<char, int> frequency = new Dictionary<char, int>();
        foreach(char c  in s) {
            if(!frequency.ContainsKey(c)) {
                frequency[c] = 0;
            }
            frequency[c]++;
        }

        for(int i = 0; i < s.Length; i++) {
            if(frequency[s[i]] < k) {
                int left = LongestSubstring(s.Substring(0, i), k);
                int right = LongestSubstring(s.Substring(i + 1), k);
                return Math.Max(left, right);
            }
        }
        return s.Length;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.LongestSubstring("aaabb", 3);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.LongestSubstring("ababbc", 2);
        Console.WriteLine("Result for case 2: " + result2);
    }
}