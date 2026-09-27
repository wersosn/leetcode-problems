// Pattern: Priority queue (min-heap)
// When to use: When you need the k points with the smallest distance to the origin
// Complexity: O(n + k log n) time and O(n) space, where n is the number of points

public class Solution {
    public int[][] KClosest(int[][] points, int k) {  
        if(points == null || k < 0) {
            return new int[0][];
        }

        PriorityQueue<int[], int> queue = new PriorityQueue<int[], int>();
        int[][] result = new int[k][];

        foreach(int[] point in points) {
            int x = point[0];
            int y = point[1];
            int distance = x*x + y*y;
            queue.Enqueue(point, distance);
        }

        for(int i = 0; i < k; i++) {
            result[i] = queue.Dequeue();
        }
        return result;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.KClosest([[1,3],[-2,2]], 1);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.KClosest([[3,3],[5,-1],[-2,4]], 2);
        Console.WriteLine("Result for case 2: " + result2);
    }
}