// Pattern: Depth-First Search (DFS) with value bounds
// When to use: When each node must satisfy constraints based on all its ancestors
// Complexity: O(n) time, O(h) space, where h is the tree height

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
    public bool IsValidBST(TreeNode root) {
        if(root == null) {
            return true;
        }
        return IsValid(root, long.MinValue, long.MaxValue);
    }

    public bool IsValid(TreeNode node, long min, long max) {
        if(node == null) {
            return true;
        }
        if(node.val <= min || node.val >= max) {
            return false;
        }
        return IsValid(node.left, min, node.val) && IsValid(node.right, node.val, max);
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        //Case 1:
        var result1 = solution.IsValidBST(new TreeNode(2, new TreeNode(1), new TreeNode(3)));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.IsValidBST(new TreeNode(5, new TreeNode(1), new TreeNode(4, new TreeNode(3), new TreeNode(6))));
        Console.WriteLine("Result for case 2: " + result2);
    }
}