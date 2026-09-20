// Pattern: Count each person's in-degree (trust received) and out-degree (trust given)
// When to use: When identifying a node with a required number of incoming and outgoing edges
// Complexity: O(n + trust.Length) time and O(n) space

public class Solution {
    public int FindJudge(int n, int[][] trust) {
        if(n <= 0 || trust == null) {
            return -1;
        }

        int[] trustedBy = new int[n + 1];
        int[] trusts = new int[n + 1];

        foreach(int[] pair in trust) {
            int a = pair[0];
            int b = pair[1];
            trustedBy[b]++;
            trusts[a]++;
        }

        for(int i = 1; i <= n; i++) {
            if(trustedBy[i] == n - 1 && trusts[i] == 0) {
                return i;
            }
        }
        return -1;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        //Case 1:
        var result1 = solution.FindJudge(2, [[1,2]]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.FindJudge(3, [[1,3],[2,3]]);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.FindJudge(3, [[1,3],[2,3],[3,1]]);
        Console.WriteLine("Result for case 3: " + result3);
    }
}