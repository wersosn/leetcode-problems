// Pattern: Stack
// When to use: Decode a string with nested patterns
// Complexity: O(n) where n is the length of the input string, O(n) space in the worst case

public class Solution {
    public string DecodeString(string s) {
        Stack<int> numbers = new Stack<int>();
        Stack<string> strings = new Stack<string>();
        string current = "";
        int num = 0;

        foreach(char c in s) {
            if(char.IsDigit(c)) {
                num = num * 10 + (c - '0');
            }
            else if(c == '[') {
                numbers.Push(num);
                strings.Push(current);
                current = "";
                num = 0;
            }
            else if(c == ']') {
                int repeat = numbers.Pop();
                string previous = strings.Pop();
                string repeated = "";
                for(int i = 0; i < repeat; i++) {
                    repeated += current;
                }
                current = previous + repeated;
            }
            else {
                current += c;
            }
        }
        return current;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.DecodeString("3[a]2[bc]");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.DecodeString("3[a2[c]]");
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.DecodeString("2[abc]3[cd]ef");
        Console.WriteLine("Result for case 3: " + result3);
    }
}