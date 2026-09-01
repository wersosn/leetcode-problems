// Pattern: Stack
// When to use: When checking if a string of parentheses is valid.
// Complexity: O(n) time and O(n) space

public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s) {
            if(c == '(' || c == '[' || c == '{') {
                stack.Push(c);
            }
            else {
                if(stack.Count == 0) {
                    return false;
                }

                if (c == ')' && stack.Peek() == '(' 
                    || c == ']' && stack.Peek() == '['
                    || c == '}' && stack.Peek() == '{' ) {
                    stack.Pop();
                }
                else {
                    return false;
                }
            }
        }

        if(stack.Count == 0) {
            return true;
        }
        return false;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.IsValid("()");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.IsValid("()[]{}");
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.IsValid("(]");
        Console.WriteLine("Result for case 3: " + result3);

        //Case 4:
        var result4 = solution.IsValid("([])");
        Console.WriteLine("Result for case 4: " + result4);

        //Case 5:
        var result5 = solution.IsValid("([)]");
        Console.WriteLine("Result for case 5: " + result5);
    }
}