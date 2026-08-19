// Pattern: Hash sets for tracking values in rows, columns, and 3x3 boxes.
// When to use: When validating uniqueness across multiple overlapping groups.
// Complexity: O(1) time and O(1) space for a 9x9 board; generally O(n^2) time and O(n^2) space.

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for(int i = 0; i < rows.Length; i++) {
            for(int j = 0; j < cols.Length; j++) {
                if(board[i][j] == '.') {
                    continue;
                }

                int boxIndex = (i/3) * 3 + (j/3);
                if(rows[i].Contains(board[i][j]) || cols[j].Contains(board[i][j]) || boxes[boxIndex].Contains(board[i][j])) {
                    return false;
                }

                rows[i].Add(board[i][j]);
                cols[j].Add(board[i][j]);
                boxes[boxIndex].Add(board[i][j]);
            }
        }
        return true;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        char[][] board = 
                        [["8","3",".",".","7",".",".",".","."]
                        ,["6",".",".","1","9","5",".",".","."]
                        ,[".","9","8",".",".",".",".","6","."]
                        ,["8",".",".",".","6",".",".",".","3"]
                        ,["4",".",".","8",".","3",".",".","1"]
                        ,["7",".",".",".","2",".",".",".","6"]
                        ,[".","6",".",".",".",".","2","8","."]
                        ,[".",".",".","4","1","9",".",".","5"]
                        ,[".",".",".",".","8",".",".","7","9"]];
        bool result1 = solution.IsValidSudoku(board);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        char[][] board2 = 
                        [["5","3",".",".","7",".",".",".","."]
                        ,["6",".",".","1","9","5",".",".","."]
                        ,[".","9","8",".",".",".",".","6","."]
                        ,["8",".",".",".","6",".",".",".","3"]
                        ,["4",".",".","8",".","3",".",".","1"]
                        ,["7",".",".",".","2",".",".",".","6"]
                        ,[".","6",".",".",".",".","2","8","."]
                        ,[".",".",".","4","1","9",".",".","5"]
                        ,[".",".",".",".","8",".",".","7","9"]];
        bool result2 = solution.IsValidSudoku(board2);
        Console.WriteLine("Result for case 2: " + result2);
    }
}