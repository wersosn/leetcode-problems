// Pattern: Descend through the BST by comparing node values.
// When to use: When you need the lowest common ancestor of two nodes in a binary search tree.
// Complexity: O(h) time, O(1) space
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null || p == null || q == null) {
            return null;
        }

        // Iterative version:
        while(root != null) {
            if(p.val < root.val && q.val < root.val) {
                root = root.left;
            }
            else if(p.val > root.val && q.val > root.val) {
                root = root.right;
            }
            else {
                return root;
            }
        }

        return null;

        // Recursive version:
        if(p.val < root.val && q.val < root.val) {
            return LowestCommonAncestor(root.left, p, q);
        }
        else if(p.val > root.val && q.val > root.val) {
            return LowestCommonAncestor(root.right, p, q);
        }
        else {
            return root;
        }
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        // Case 1:
        var root1 = new TreeNode(6, new TreeNode(2, new TreeNode(0), new TreeNode(4, new TreeNode(3), new TreeNode(5))), new TreeNode(8, new TreeNode(7), new TreeNode(9)));
        var result1 = solution.LowestCommonAncestor(root1, new TreeNode(2), new TreeNode(8));
        Console.WriteLine("Result for case 1: " + result1.val);

        // Case 2:
        var root2 = new TreeNode(6, new TreeNode(2, new TreeNode(0), new TreeNode(4, new TreeNode(3), new TreeNode(5))), new TreeNode(8, new TreeNode(7), new TreeNode(9)));
        var result2 = solution.LowestCommonAncestor(root2, new TreeNode(2), new TreeNode(4));
        Console.WriteLine("Result for case 2: " + result2.val);

        // Case 3:
        var root3 = new TreeNode(2, new TreeNode(1));
        var result3 = solution.LowestCommonAncestor(root3, new TreeNode(2), new TreeNode(1));
        Console.WriteLine("Result for case 3: " + result3.val);
    }
}

