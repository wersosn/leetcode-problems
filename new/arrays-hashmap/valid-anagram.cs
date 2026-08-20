// Pattern: Dictionary for tracking "what I've seen so far"
// When to use: When you need to determine if two strings are anagrams of each other (i.e., they contain the same characters in a different order).
// Complexity: O(n) time, O(n) space.

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> anagram = new Dictionary<char, int>();

        foreach(char c in s) {
            if(!anagram.ContainsKey(c)) {
                anagram[c] = 0;
            }
            anagram[c]++;
        }

        foreach(char c in t) {
            if(!anagram.ContainsKey(c)) {
                return false;
            }
            anagram[c]--;
        }

        foreach(int a in anagram.Values) {
            if(a != 0) {
                return false;
            }
        }
        return true;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.ValidAnagram("anagram", "nagaram");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.ValidAnagram("rat", "car");
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.ValidAnagram("listen", "silent");
        Console.WriteLine("Result for case 3: " + result3);
    }
}