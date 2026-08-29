// Pattern: Sliding window
// When to use: Use this pattern when you need to find the shortest/longest substring that satisfies a condition based on counts or frequency constraints.
// Complexity: O(n) time, O(k) space, where k is the number of unique characters in t.

public class Solution {
    public string MinWindow(string s, string t) {
        if(s.Length < t.Length) {
            return "";
        }

        int left = 0;
        Dictionary<char, int> need = new Dictionary<char, int>();
        Dictionary<char, int> window = new Dictionary<char, int>();

        foreach(char c in t) {
            if(!need.ContainsKey(c)) {
                need[c] = 0;
            }
            need[c]++;
        }

        int have = 0;
        int required = need.Count;

        int minLength = int.MaxValue;
        int minLeft = 0;

        for(int right = 0; right < s.Length; right++) {
            if(!window.ContainsKey(s[right])) {
                window[s[right]] = 0;
            }
            window[s[right]]++;

            if(need.ContainsKey(s[right]) && need[s[right]] == window[s[right]]) {
                have++;
            }

            while(have == required) {
                if(right - left + 1 < minLength) {
                    minLength = right - left + 1;
                    minLeft = left;
                }

                window[s[left]]--;
                if (need.ContainsKey(s[left]) && need[s[left]] > window[s[left]]) {
                    have--;
                }
                left++;
            }
        }

        if (minLength == int.MaxValue) {
            return "";
        }

        return s.Substring(minLeft, minLength);
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.MinWindow("ADOBECODEBANC", "ABC");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.MinWindow("a", "a");
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.MinWindow("a", "aa");
        Console.WriteLine("Result for case 3: " + result3);
    }
}