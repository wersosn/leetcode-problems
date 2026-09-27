// Pattern: Priority queue (min-heap)
// When to use: When you need to continuously add numbers and efficiently find the median of all numbers seen so far
// Complexity: AddNum: O(log n), FindMedian: O(1) time and O(n) space

public class MedianFinder
{
    PriorityQueue<int, int> minQueue = new PriorityQueue<int, int>();
    PriorityQueue<int, int> maxQueue = new PriorityQueue<int, int>();

    public MedianFinder()
    {

    }

    public void AddNum(int num)
    {
        if (minQueue.Count == 0 || num < minQueue.Peek())
        {
            minQueue.Enqueue(num, -num);
        }
        else
        {
            maxQueue.Enqueue(num, num);
        }

        if (minQueue.Count > maxQueue.Count + 1)
        {
            int n = minQueue.Dequeue();
            maxQueue.Enqueue(n, n);
        }

        if (maxQueue.Count > minQueue.Count)
        {
            int n = maxQueue.Dequeue();
            minQueue.Enqueue(n, -n);
        }
    }

    public double FindMedian()
    {
        if (minQueue.Count > maxQueue.Count)
        {
            return minQueue.Peek();
        }

        int leftMax = minQueue.Peek();
        int rightMin = maxQueue.Peek();
        return (leftMax + rightMin) / 2.0;
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */

// Cases:
class Program
{
    public static void Main()
    {
        MedianFinder medianFinder = new MedianFinder();

        //Case 1:
        medianFinder.addNum(1);
        medianFinder.addNum(2);
        medianFinder.findMedian();
        medianFinder.addNum(3);
        medianFinder.findMedian();
    }
}