// Pattern: Stack
// When to use: Simulating collisions between asteroids moving in opposite directions, using a stack to keep track of surviving asteroids
// Complexity: O(n) time, O(n) space

public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();
        foreach(int asteroid in asteroids) {
            bool destroyed = false;
            while(stack.Count > 0 && stack.Peek() > 0 && asteroid < 0) {
                if(Math.Abs(stack.Peek()) < Math.Abs(asteroid)) {
                    stack.Pop();
                }
                else if (Math.Abs(stack.Peek()) == Math.Abs(asteroid)){
                    stack.Pop();
                    destroyed = true;  
                    break;  
                }
                else {
                    destroyed = true; 
                    break;
                }
            }

            if(!destroyed)
            {
                stack.Push(asteroid);
            }
        }
        return stack.Reverse().ToArray();
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.AsteroidCollision(new int[] { 5, 10, -5 });
        Console.WriteLine("Result for case 1: " + string.Join(", ", result1));

        //Case 2:
        var result2 = solution.AsteroidCollision(new int[] { 8, -8 });
        Console.WriteLine("Result for case 2: " + string.Join(", ", result2));

        //Case 3:
        var result3 = solution.AsteroidCollision(new int[] { 10, 2, -5 });
        Console.WriteLine("Result for case 3: " + string.Join(", ", result3));

        //Case 4:
        var result4 = solution.AsteroidCollision(new int[] { 3, 5, -6, 2, -1, 4 });
        Console.WriteLine("Result for case 4: " + string.Join(", ", result4));
    }
}