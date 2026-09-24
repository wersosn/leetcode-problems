// Pattern: Priority queue (max-heap simulated with negative priorities)
// When to use: When elements must be processed in descending score order
// Complexity: O(n log n) time, O(n) space

public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        if(score == null) {
            return new string[0];
        }

        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        string[] answer = new string[score.Length];   
        for(int i = 0; i < score.Length; i++) {
            queue.Enqueue(i, -score[i]);
        }

        int place = 1;
        while(queue.Count > 0) {
            int index = queue.Dequeue();
            if(place == 1)
            {
                answer[index] = "Gold Medal";
            }
            else if(place == 2)
            {
                answer[index] = "Silver Medal";
            }
            else if(place == 3)
            {
                answer[index] = "Bronze Medal";
            }
            else
            {
                answer[index] = place.ToString();
            }
            place++;
        }
        return answer;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.FindRelativeRanks([5,4,3,2,1]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.FindRelativeRanks([10,3,8,9,4]);
        Console.WriteLine("Result for case 2: " + result2);
    }
}