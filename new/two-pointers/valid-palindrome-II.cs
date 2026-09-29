// Pattern: Two Pointers
// When to use: When checking whether a string can become a palindrome after deleting at most one character
// Complexity: O(n) time and O(n) space due to the character array (O(1) extra space)

public class Solution {
    public bool ValidPalindrome(string s) {
        char[] og = s.ToCharArray();

        for(int i = 0, j = og.Length - 1; i < j; i++, j--) {
            if(og[i] != og[j]) {
                return IsPalindrome(og, i + 1, j) || IsPalindrome(og, i, j - 1);
            }
        }
        return true;
    }

    public bool IsPalindrome(char[] c, int left, int right) {
        while(left < right) {
            if(c[left] == c[right]) {
                left++;
                right--;
            }
            else {
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
        var result1 = solution.ValidPalindrome("aba");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.ValidPalindrome("abca");
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.IValidPalindrome("abc");
        Console.WriteLine("Result for case 3: " + result3);
    }
}