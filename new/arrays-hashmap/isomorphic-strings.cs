// Pattern: Two-way mapping (bidirectional hash maps)
// When to use: When checking whether two sequences have a one-to-one correspondence
// Complexity: O(n) time and O(n) space

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }

        Dictionary<char, char> SmapToT = new Dictionary<char, char>();
        Dictionary<char, char> TmapToS = new Dictionary<char, char>();
        for(int i = 0; i < s.Length; i++) {
            char charS = s[i];
            char charT = t[i];

            if(SmapToT.ContainsKey(charS) && SmapToT[charS] != charT) {
                return false;
            }

            if(TmapToS.ContainsKey(charT) && TmapToS[charT] != charS) {
                return false;
            }

            SmapToT[charS] = charT;
            TmapToS[charT] = charS;
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
        bool result1 = solution.IsIsomorphic("egg", "add");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        bool result2 = solution.IsIsomorphic("f11", "b23");
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        bool result3 = solution.IsIsomorphic("paper", "title");
        Console.WriteLine("Result for case 3: " + result3);
    }
}

