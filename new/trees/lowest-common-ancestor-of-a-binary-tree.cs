// Pattern: Recursive depth-first search (DFS)
// When to use: Finding the lowest node that contains p and q in its subtree
// Complexity: O(n) time, O(h) space, where h is the tree height

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null || p == null || q == null) {
            return null;
        }

        if(root == p || root == q) {
            return root;
        }
        
        TreeNode left = LowestCommonAncestor(root.left, p, q);
        TreeNode right = LowestCommonAncestor(root.right, p, q);

        if(left != null && right != null) {
            return root;
        }
        else if(left == null) {
            return right;
        }
        else {
            return left;
        }
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        //Case 1:
        var result1 = solution.LowestCommonAncestor(new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(2, null, new TreeNode(7, null, new TreeNode(4)))), new TreeNode(1, new TreeNode(0), new TreeNode(8))), new TreeNode(5), new TreeNode(1));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.LowestCommonAncestor(new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(2, null, new TreeNode(7, null, new TreeNode(4)))), new TreeNode(1, new TreeNode(0), new TreeNode(8))), new TreeNode(5), new TreeNode(4));
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.LowestCommonAncestor(new TreeNode(1), new TreeNode(2), new TreeNode(1), new TreeNode(2));
        Console.WriteLine("Result for case 3: " + result3);
    }
}