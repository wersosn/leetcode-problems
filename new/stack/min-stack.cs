// Pattern: Stack
// When to use: Track minimum value while supporting push/pop operations
// Complexity: O(1) for all operations (Push, Pop, Top, GetMin)

public class MinStack {
    Stack<int> stack = new Stack<int>();
    Stack<int> minStack = new Stack<int>();

    public MinStack() {
    }
    
    public void Push(int value) {
        stack.Push(value);

        if(minStack.Count == 0) {
            minStack.Push(value);
        }
        else {
            int minValue = Math.Min(value, minStack.Peek());
            minStack.Push(minValue);
        }
    }
    
    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(value);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */

 // Cases:
class Program
{
    public static void Main()
    {
        MinStack obj = new MinStack();
        
        // Case 1:
        obj.Push(1);
        obj.Push(2);
        obj.Push(0);
        Console.WriteLine(obj.GetMin());  // Output: 0
        obj.Pop();
        Console.WriteLine(obj.Top());     // Output: 2
        Console.WriteLine(obj.GetMin());  // Output: 1
    }
}