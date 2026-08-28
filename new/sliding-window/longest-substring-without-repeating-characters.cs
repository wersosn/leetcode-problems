// Pattern: Sliding window with a list of characters in the current window.
// When to use: When tracking a contiguous substring and removing characters from the left whenever a duplicate is found.
// Complexity: O(n^2) time because Contains, IndexOf, and RemoveRange are linear; O(n) space.

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        char[] chars = s.ToCharArray();
        int longest = 0;
        List<char> seen = new List<char>();

        for(int i = 0; i < chars.Length; i++) {
            if(seen.Contains(chars[i])) {
                int index = seen.IndexOf(chars[i]);
                seen.RemoveRange(0, index + 1);
            }

            seen.Add(chars[i]);
            
            if(seen.Count > longest) {
                longest = seen.Count;
            }
        }
        return longest;
    }
}

// or: 
// Pattern: Sliding window with a dictionary storing each character's latest index.
// When to use: When the left boundary can jump directly past a duplicate.
// Complexity: O(n) average time and O(min(n, character-set-size)) space.
public class Solution {
    public int LengthOfLongestSubstringTwo(string s) {
        char[] chars = s.ToCharArray();
        int left = 0, longest = 0, currentLength = 0;
        Dictionary<char, int> seen = new Dictionary<char, int>();

        for(int i = 0; i < chars.Length; i++) {
           char current = chars[i];
           if(seen.ContainsKey(current)) {
                left = Math.Max(left, seen[current] + 1);
           }
           seen[current] = i;

           currentLength = i - left + 1;
           if(currentLength > longest) {
                longest = currentLength;
           }
        }
        return longest;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.LengthOfLongestSubstring("abcabcbb");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.LengthOfLongestSubstring("bbbbb");
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.LengthOfLongestSubstring("pwwkew");
        Console.WriteLine("Result for case 3: " + result3);
    }
}
