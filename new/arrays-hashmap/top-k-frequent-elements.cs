// Pattern: Dictionary for tracking "what I've seen so far"
// When to use: When you need to count occurrences of each element and then select the top/bottom K based on how often they appear
// Complexity: O(nlogn) time (due to sorting), O(n) space

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> mostFrequent = new Dictionary<int, int>();

        foreach(int n in nums) {
            if(!mostFrequent.ContainsKey(n)) {
                mostFrequent[n] = 0;
            }
            mostFrequent[n]++;
        }

        var result = mostFrequent.OrderByDescending(x => x.Value)
                    .Take(k)
                    .Select(x => x.Key)
                    .ToArray();
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
        var result1 = solution.TopKFrequent([1, 1, 1, 2, 2, 3], 2);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.TopKFrequent([1], 1);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.TopKFrequent([1, 2, 1, 2, 1, 2, 3, 1, 3, 2], 2);
        Console.WriteLine("Result for case 3: " + result3);
    }
}