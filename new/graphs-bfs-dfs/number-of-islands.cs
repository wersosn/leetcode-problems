// Pattern: Graph traversal (iterative DFS) on a 2D grid
// When to use: Use DFS/BFS to explore all connected land cells and count each island once
// Complexity: O(rows * columns) time and O(rows * columns) space in the worst case

public class Solution {
    public int NumIslands(char[][] grid) {
        int islands = 0;
        Stack<(int rows, int cols)> stack = new Stack<(int rows, int cols)>();

        for(int i = 0; i < grid.Length; i++) { // rows
            for(int j = 0; j < grid[0].Length; j++) { // columns
                if(grid[i][j] == '1') {
                    islands++;
                    stack.Push((i, j));
                    while(stack.Count > 0) {
                        var (row, col) = stack.Pop();
                        grid[row][col] = 'x';
                        if(row - 1 >= 0 && grid[row - 1][col] == '1') { // up
                            stack.Push((row - 1, col));
                        }
                        if(row + 1 < grid.Length && grid[row + 1][col] == '1') { // down
                            stack.Push((row + 1, col));
                        }
                        if(col - 1 >= 0 && grid[row][col - 1] == '1') { // left
                            stack.Push((row, col - 1));
                        }
                        if(col + 1 < grid[0].Length && grid[row][col + 1] == '1') { // right
                            stack.Push((row, col + 1));
                        }
                    }
                }
            }
        }
        return islands;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        //Case 1:
        var result1 = solution.NumIslands(new char[][] { new char[] { '1', '1', '1', '1', '0' }, new char[] { '1', '1', '0', '1', '0' }, new char[] { '1', '1', '0', '0', '0' }, new char[] { '0', '0', '0', '0', '0' } });
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.NumIslands(new char[][] { new char[] { '1', '1', '0', '0', '0' }, new char[] { '1', '1', '0', '0', '0' }, new char[] { '0', '0', '1', '0', '0' }, new char[] { '0', '0', '0', '1', '1' } });
        Console.WriteLine("Result for case 2: " + result2);
    }
}
