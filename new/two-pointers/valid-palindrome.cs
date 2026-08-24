// Pattern: Two Pointers
// When to use: Checking palindromes, comparing elements from both ends moving towards center
// Complexity: O(n) time, O(n) space (for cleaned character array)

public class Solution {
    public bool IsPalindrome(string s) {
        char[] og = string.Concat(s.Where(char.IsLetterOrDigit)).ToLower().ToCharArray();

        for(int i = 0, j = og.Length - 1; i < j; i++, j--) {
            if(og[i] != og[j]) {
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
        var result1 = solution.IsPalindrome("A man, a plan, a canal: Panama");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.IsPalindrome("race a car");
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.IsPalindrome(" ");
        Console.WriteLine("Result for case 3: " + result3);
    }
}