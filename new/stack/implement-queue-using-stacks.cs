// Pattern: Stack
// When to use: Implement a queue using two stacks
// Complexity: O(1) for all operations (Push, Pop, Top, GetMin)

public class MyQueue
{
    Stack<int> stack1 = new Stack<int>();
    Stack<int> stack2 = new Stack<int>();

    public MyQueue()
    {

    }

    public void Push(int x)
    {
        stack1.Push(x);
    }

    public int Pop()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }
        return stack2.Pop();
    }

    public int Peek()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }
        return stack2.Peek();
    }

    public bool Empty()
    {
        if (stack1.Count == 0 && stack2.Count == 0)
        {
            return true;
        }
        return false;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */

// Cases:
class Program
{
    public static void Main()
    {
        MyQueue myQueue = new MyQueue();

        // Case 1:
        myQueue.Push(1); // queue is: [1]
        myQueue.Push(2); // queue is: [1, 2] (leftmost is front of the queue)
        myQueue.Peek(); // return 1
        myQueue.Pop(); // return 1, queue is [2]
        myQueue.Empty(); // return false
    }
}