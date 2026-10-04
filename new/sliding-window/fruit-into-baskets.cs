// Pattern: Sliding Window
// When to use: Find the longest contiguous subarray containing at most two distinct values
// Complexity: O(n) time and O(1) space (the window stores at most two distinct values)

public class Solution {
    public int TotalFruit(int[] fruits) {
        int left = 0;
        int maxFruits = 0;

        Dictionary<int, int> window = new Dictionary<int, int>();
        for(int right = 0; right < fruits.Length; right++) {
            if(!window.ContainsKey(fruits[right])) {
                window[fruits[right]] = 0;
            }
            window[fruits[right]]++;

            while(window.Count > 2) {
                window[fruits[left]]--;
                if (window[fruits[left]] == 0) {
                    window.Remove(fruits[left]);
                }
                left++;
            }

            maxFruits = Math.Max(maxFruits, right - left + 1);
        }
        return maxFruits;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.TotalFruit(new int[] { 1, 2, 1 });
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.TotalFruit(new int[] { 0, 1, 2, 2 });
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.TotalFruit(new int[] { 1, 2, 3, 2, 2 });
        Console.WriteLine("Result for case 3: " + result3);
    }
}