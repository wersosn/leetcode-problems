// Pattern: Backtracking
// When to use: Generate all valid partitions by trying each possible next substring
// Complexity: O(n^2 * 2^n) time, O(n * 2^n) space including the output

public class Solution {
    public IList<IList<string>> Partition(string s) {
        IList<IList<string>> result = new List<IList<string>>();
        if(s == null) {
            return result;
        }

        List<string> partition = new List<string>();
        void Backtrack(int start) {
            if(start == s.Length) {
                result.Add(new List<string>(partition));
                return;
            }
            for(int i = start; i < s.Length; i++) {
                if(IsPalindrome(s.Substring(start, i - start + 1))) {
                    partition.Add(s.Substring(start, i - start + 1));
                    Backtrack(i + 1);
                    partition.RemoveAt(partition.Count - 1);
                }
            }
        }
        Backtrack(0);
        return result;
    }

    public bool IsPalindrome(string s) {
        for(int i = 0, j = s.Length - 1; i < j; i++, j--) {
            if(s[i] != s[j]) {
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
        var result1 = solution.Partition("aab");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.Partition("a");
        Console.WriteLine("Result for case 2: " + result2);
    }
}