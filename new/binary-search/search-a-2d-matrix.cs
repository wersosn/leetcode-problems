// Pattern: Binary Search
// When to use: Search for a value in a 2D matrix where each row and column is sorted
// Complexity: O(log(m * n)) time, O(1) space

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int left = 0;
        int right = matrix.Length * matrix[0].Length - 1;
        while(left <= right) {
            int middle = left + (right - left) / 2;
            int row = middle / matrix[0].Length;
            int col = middle % matrix[0].Length;
            if(matrix[row][col] == target) {
                return true;
            }
            else if(matrix[row][col] < target) {
                left = middle + 1;
            }
            else {
                right = middle - 1;
            }
        }
        return false;
    }
}


// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.SearchMatrix(new int[][] { new int[] {1, 3, 5, 7}, new int[] {10, 11, 16, 20}, new int[] {23, 30, 34, 60} }, 3);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.SearchMatrix(new int[][] { new int[] {1, 3, 5, 7}, new int[] {10, 11, 16, 20}, new int[] {23, 30, 34, 60} }, 13);
        Console.WriteLine("Result for case 2: " + result2);
    }
}