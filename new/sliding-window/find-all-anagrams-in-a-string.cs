// Pattern: Sliding Window with Frequency Map
// When to use: Use this when you need to find all substrings of a fixed length that are anagrams of a given pattern
// Complexity: O(n) time, O(k) space, where k is the number of unique characters in the pattern and the window

public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        IList<int> result = new List<int>();
        if(s.Length < p.Length) {
            return result;
        }

        Dictionary<char, int> target = new Dictionary<char, int>();
        foreach(char c in p) {
            if(!target.ContainsKey(c)) {
                target[c] = 0;
            }
            target[c]++;
        }

        Dictionary<char, int> window = new Dictionary<char, int>();
        int left = 0;
        for(int right = 0; right < s.Length; right++) {
            if(!window.ContainsKey(s[right])) {
                window[s[right]] = 0;
            }
            window[s[right]]++;

            if(right - left + 1 > p.Length) {
                window[s[left]]--;
                if (window[s[left]] == 0) {
                    window.Remove(s[left]);
                }
                left++;
            } 

            if(right - left + 1 == p.Length && target.Count == window.Count && 
                window.All(x => target.ContainsKey(x.Key) && target[x.Key] == x.Value)) {
                result.Add(left);
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
        var result1 = solution.FindAnagrams("cbaebabacd", "abc");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.FindAnagrams("abab", "ab");
        Console.WriteLine("Result for case 2: " + result2);
    }
}