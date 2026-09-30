// Pattern: Two pointers with greedy pairing after sorting.
// When to use: When each boat can carry at most two people and you need to minimize boats
// Complexity: O(n log n) time for sorting and O(1) extra space (excluding the sort implementation)

public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int maxBoats = 0;
        int left = 0, right = people.Length - 1;
        while(left <= right) {
            if(people[left] + people[right] <= limit) {
                left++;
                right--;
            }
            else {
                right--;
            }
            maxBoats++;
        }
        return maxBoats;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.NumRescueBoats([1,2], 3);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.NumRescueBoats([3,2,2,1], 3);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.NumRescueBoats([3,5,3,4], 5);
        Console.WriteLine("Result for case 3: " + result3);
    }
}