// Pattern: Sliding Window
// When to use: Find the maximum value in each sliding window of size k in an array
// Complexity: O(n) time and O(k) space (the deque stores at most k indices)

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        List<int> result = new List<int>();
        LinkedList<int> deque = new LinkedList<int>(); // monotonic queue / double-ended queue to store indices of elements in the current window

        for(int right = 0; right < nums.Length; right++) {
            int left = right - k + 1;
            if(deque.Count > 0 && deque.First.Value < left) {
                deque.RemoveFirst();
            }

            while(deque.Count > 0 && nums[deque.Last.Value] <= nums[right]) {
                deque.RemoveLast();
            }
            deque.AddLast(right);

            if(right >= k - 1) {
                result.Add(nums[deque.First.Value]);
            }
        }
        return result.ToArray();
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.MaxSlidingWindow(new int[] { 1 }, 1);
        Console.WriteLine("Result for case 2: " + result2);
    }
}