// Pattern: Depth-first search (DFS) or recursion
// When to use: When you want to invert a binary tree
// Complexity: O(n) time, O(1) space, where n is the number of nodes in the tree

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
    public TreeNode InvertTree(TreeNode root) {
        if(root == null) {
            return null;
        }

        TreeNode tmp = root.left;
        root.left = root.right;
        root.right = tmp;

        InvertTree(root.left);
        InvertTree(root.right);

        return root;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.InvertTree(new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9))));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.InvertTree(new TreeNode(2, new TreeNode(1), new TreeNode(3)));
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.InvertTree(null);
        Console.WriteLine("Result for case 3: " + result3);
    }
}