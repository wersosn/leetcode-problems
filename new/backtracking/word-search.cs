// Pattern: Backtracking with DFS and in-place visited marking
// When to use: When searching for a path through adjacent cells while preventing cell reuse
// Complexity: O(R * C * 4^L) time and O(L) auxiliary space, where L is word.Length

public class Solution {
    public bool Exist(char[][] board, string word) {
        if(board == null || word == null) {
            return false;
        }

        bool Backtrack(int idx, int row, int col) {
            if(row < 0 || row >= board.Length || col < 0 || col >= board[0].Length) {
                return false;
            }

            if(board[row][col] != word[idx])
            {
                return false;
            }

            if(idx == word.Length - 1) {
                return true;
            }

            char letter = word[idx];
            board[row][col] = 'X';       

            bool found =
                Backtrack(idx + 1, row - 1, col) || // up
                Backtrack(idx + 1, row + 1, col) || // down
                Backtrack(idx + 1, row, col - 1) || // left
                Backtrack(idx + 1, row, col + 1); // right

            board[row][col] = letter; 
            return found;
        }

        for(int i = 0; i < board.Length; i++) {
            for(int j = 0; j < board[0].Length; j++) {
                if(board[i][j] == word[0]) {
                    if(Backtrack(0, i, j)) {
                        return true;
                    }
                }
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
        var result1 = solution.Exist([["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], "ABCCED");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.Exist([["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], "SEE");
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.Exist([["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], "ABCB");
        Console.WriteLine("Result for case 3: " + result3);
    }
}