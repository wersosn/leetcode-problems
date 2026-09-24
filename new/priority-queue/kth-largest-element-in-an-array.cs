// Pattern: Maintain a priority queue (min-heap) of the k largest elements seen so far
// When to use: When finding the kth largest element efficiently without sorting the entire array
// Complexity: O(n log k) time and O(k) space

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        if(nums == null || k <= 0) {
            return 0;
        }

        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        foreach(int n in nums) {
            queue.Enqueue(n, n);
            if(queue.Count > k) {
                queue.Dequeue();
            }
        }

        return queue.Peek();
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.FindKthLargest([3,2,1,5,6,4], 2);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.FindKthLargest([3,2,3,1,2,4,5,5,6], 4);
        Console.WriteLine("Result for case 2: " + result2);
    }
}