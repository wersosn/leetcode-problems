// Pattern: Stack
// When to use: Removing adjacent duplicates in a string, using a stack to keep track of characters
// Complexity: O(n) time, O(n) space

public class Solution {
    public string RemoveDuplicates(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s) {
            if(stack.Count > 0 && stack.Peek() == c) {
                stack.Pop();
            }
            else {
                stack.Push(c);
            }
        }
        return new string(stack.Reverse().ToArray());
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.RemoveDuplicates("abbaca");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.RemoveDuplicates("azxxzy");
        Console.WriteLine("Result for case 2: " + result2);
    }
}