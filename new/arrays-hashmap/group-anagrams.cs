// Pattern: Dictionary for tracking "what I've seen so far"
// When to use: When you need to group strings that are anagrams of each other (i.e., they contain the same characters in a different order).
// Complexity: O(n * k log k) time, O(n * k) space, where n is the number of strings and k is the maximum length of a string.

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        foreach(string s in strs) 
        {
            char[] characters = s.ToCharArray();
            Array.Sort(characters);
            string sortedString = new string(characters);

            if(!anagrams.ContainsKey(sortedString)) 
            {
                anagrams[sortedString] = new List<string>();
            }
            anagrams[sortedString].Add(s);
        }
        return new List<IList<string>>(anagrams.Values);
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        bool result1 = solution.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        bool result2 = solution.GroupAnagrams(new string[] { "abc", "bca", "cab", "xyz", "zyx" });
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        bool result3 = solution.GroupAnagrams(new string[] { " " });
        Console.WriteLine("Result for case 3: " + result3);
    }
}