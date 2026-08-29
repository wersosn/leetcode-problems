// Pattern: Sliding window
// When to use: Use this when you need to check whether any substring of a string contains the exact same characters as another string (anagram / permutation check).
// Complexity: O(s2.Length + s1.Length) time, O(k) space where k is the number of distinct characters in s1.

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) {
            return false;
        }
        
        int left = 0;
        Dictionary<char, int> need = new Dictionary<char, int>();
        Dictionary<char, int> window = new Dictionary<char, int>();

        foreach(char c in s1) {
            if(!need.ContainsKey(c)) {
                need[c] = 0;
            }
            need[c]++;
        }

        int windowSize = s1.Length;

        for(int right = 0; right < s2.Length; right++) {
            if(!window.ContainsKey(s2[right])) {
                window[s2[right]] = 0;
            }
            window[s2[right]]++;

            if(right - left + 1 > windowSize) {
                window[s2[left]]--;
                if (window[s2[left]] == 0) {
                    window.Remove(s2[left]);
                }
                left++;
            }

            if(right - left + 1 == windowSize && need.Count == window.Count && 
                window.All(x => need.ContainsKey(x.Key) && need[x.Key] == x.Value)) {
                    return true;
                }
        }
        return false;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.CheckInclusion("ab", "eidbaooo");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.CheckInclusion("ab", "eidboaoo");
        Console.WriteLine("Result for case 2: " + result2);
    }
}