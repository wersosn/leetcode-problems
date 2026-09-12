// Pattern: Depth-first search (DFS) or recursion
// When to use: When you want to find the maximum depth of a binary tree
// Complexity: O(n) time, O(h) space, where n is the number of nodes in the tree and h is the height of the tree (due to recursion stack)

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode root) {
        if(root == null) {
            return 0;
        }

        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);
        return Math.Max(leftDepth, rightDepth) + 1;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.MaxDepth(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.MaxDepth(new TreeNode(1, null, new TreeNode(2)));
        Console.WriteLine("Result for case 2: " + result2);
    }
}