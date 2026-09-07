// Pattern: Binary Search
// When to use: Searching for the first occurrence of a condition in a range of versions, finding the first bad version efficiently
// Complexity: O(log n) time, O(1) space

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left = 0, right = n;
        while(left < right) {
            int middle = left + (right - left) / 2;
            if(IsBadVersion(middle)) {
                right = middle;
            }
            else {
                left = middle + 1;
            }
        }
        return left;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.FirstBadVersion(5); // Assuming version 4 is the first bad version
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.FirstBadVersion(10); // Assuming version 7 is the first bad version
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.FirstBadVersion(1); // Assuming version 1 is the first bad version
        Console.WriteLine("Result for case 3: " + result3);
    }
}