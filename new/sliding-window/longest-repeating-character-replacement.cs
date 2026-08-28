// Pattern: Sliding window
// When to use: Find longest substring with at most k character replacements
// Complexity: O(n) time, O(1) space (max 26 letters in dictionary)

public class Solution {
    public int CharacterReplacement(string s, int k) {
        char[] chars = s.ToCharArray();
        int longest = 0;
        int left = 0;
        int maxFrequency = 0;
        Dictionary<char, int> count = new Dictionary<char, int>();

        for(int i = 0; i < chars.Length; i++) {
            if (!count.ContainsKey(chars[i])) {
                count[chars[i]] = 0;
            }
            
            count[chars[i]]++;
            maxFrequency = Math.Max(maxFrequency, count[chars[i]]);

            while(i - left + 1 - maxFrequency > k) {
                count[chars[left]]--;
                left++;
            }

            if(i - left + 1 > longest) {
                longest = i - left + 1;
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
        var result1 = solution.CharacterReplacement("ABAB", 2);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.CharacterReplacement("AABABBA", 1);
        Console.WriteLine("Result for case 2: " + result2);
    }
}