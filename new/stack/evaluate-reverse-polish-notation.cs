// Pattern: Stack
// When to use: Evaluating postfix expressions, handling operator precedence without parentheses
// Complexity: O(n) time, O(n) space

public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        foreach(string s in tokens) {
            if(int.TryParse(s, out int number)) {
                stack.Push(number);
            }
            else {
                if(s == "+") {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b + a);
                }
                else if(s == "-") {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b - a);
                }
                else if(s == "*") {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b * a);
                }
                else if(s == "/") {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b / a);
                }
            }
        }

        return stack.Pop();
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.EvalRPN(new string[] { "2", "1", "+", "3", "*" });
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.EvalRPN(new string[] { "4", "13", "5", "/", "+" });
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.EvalRPN(new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "-" });
        Console.WriteLine("Result for case 3: " + result3);
    }
}