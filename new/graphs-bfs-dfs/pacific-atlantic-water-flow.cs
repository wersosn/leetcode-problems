// Pattern: Multi-source BFS from each ocean's boundary, traversing to cells with equal or greater height (reverse water-flow direction)
// When to use: When a grid problem asks which cells can reach multiple boundaries or destinations under movement constraints
// Complexity: O(rows * cols) time and O(rows * cols) space

public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        if(heights == null) {
            return new List<IList<int>>();
        }

        IList<IList<int>> result = new List<IList<int>>();

        int rows = heights.Length;
        int cols = heights[0].Length;
        bool[][] pacific = new bool[rows][];
        bool[][] atlantic = new bool[rows][];
        for(int i = 0; i < rows; i++) {
            pacific[i] = new bool[cols];
            atlantic[i] = new bool[cols];
        }

        // Pacific ocean:
        Queue<(int row, int col)> pacificQueue = new Queue<(int row, int col)>();
        // North part:
        for(int i = 0; i < cols; i++) {
            pacific[0][i] = true;
            pacificQueue.Enqueue((0, i));
        }

        // Left part:
        for(int i = 0; i < rows; i++) {
            if(!pacific[i][0]) {
                pacific[i][0] = true;
                pacificQueue.Enqueue((i, 0));
            }
        }

        while(pacificQueue.Count > 0) {
            var (row, col) = pacificQueue.Dequeue();
            if(row - 1 >= 0 && !pacific[row - 1][col] && heights[row - 1][col] >= heights[row][col]) { // up
                pacific[row - 1][col] = true;
                pacificQueue.Enqueue((row - 1, col));
            }
            if(row + 1 < pacific.Length && !pacific[row + 1][col] && heights[row + 1][col] >= heights[row][col]) { // down
                pacific[row + 1][col] = true;
                pacificQueue.Enqueue((row + 1, col));
            }
            if(col - 1 >= 0 && !pacific[row][col - 1] && heights[row][col - 1] >= heights[row][col]) { // left
                pacific[row][col - 1] = true;
                pacificQueue.Enqueue((row, col - 1));
            }
            if(col + 1 < pacific[0].Length && !pacific[row][col + 1] && heights[row][col + 1] >= heights[row][col]) { // right
                pacific[row][col + 1] = true;
                pacificQueue.Enqueue((row, col + 1));
            }
        }

        // Atlantic ocean:
        Queue<(int row, int col)> atlanticQueue = new Queue<(int row, int col)>();
        // South part:
        for(int j = 0; j < cols; j++) {
            atlantic[rows - 1][j] = true;
            atlanticQueue.Enqueue((rows - 1, j));
        }

        // Right part:
        for(int j = 0; j < rows; j++) {
            if(!atlantic[j][cols - 1]) {
                atlantic[j][cols - 1] = true;
                atlanticQueue.Enqueue((j, cols - 1));
            }
        }

        while(atlanticQueue.Count > 0) {
            var (row, col) = atlanticQueue.Dequeue();
            if(row - 1 >= 0 && !atlantic[row - 1][col] && heights[row - 1][col] >= heights[row][col]) { // up
                atlantic[row - 1][col] = true;
                atlanticQueue.Enqueue((row - 1, col));
            }
            if(row + 1 < atlantic.Length && !atlantic[row + 1][col] && heights[row + 1][col] >= heights[row][col]) { // down
                atlantic[row + 1][col] = true;
                atlanticQueue.Enqueue((row + 1, col));
            }
            if(col - 1 >= 0 && !atlantic[row][col - 1] && heights[row][col - 1] >= heights[row][col]) { // left
                atlantic[row][col - 1] = true;
                atlanticQueue.Enqueue((row, col - 1));
            }
            if(col + 1 < atlantic[0].Length && !atlantic[row][col + 1] && heights[row][col + 1] >= heights[row][col]) { // right
                atlantic[row][col + 1] = true;
                atlanticQueue.Enqueue((row, col + 1));
            }
        }

        for(int i = 0; i < rows; i++) {
            for(int j = 0; j < cols; j++) {
                if(pacific[i][j] && atlantic[i][j]) {
                    result.Add(new List<int> {i, j});
                }
            }
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
        var result1 = solution.PacificAtlantic([[1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.PacificAtlantic([[1]]);
        Console.WriteLine("Result for case 2: " + result2);
    }
}
