// Pattern: Recursive depth-first search (DFS)
// When to use: When checking whether one binary tree is an exact subtree of another
// Complexity: O(n * m) time worst case; O(h + k) space, where n/m are tree sizes and h/k are their heights

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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null || subRoot == null) {
            return false;
        }

        if(IsSameTree(root, subRoot)) {
            return true;
        }

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null) {
            return true;
        }

        if(p == null || q == null || p.val != q.val) {
            return false;
        }

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var root1 = new TreeNode(3, new TreeNode(4, new TreeNode(1), new TreeNode(2)), new TreeNode(5));
        var subRoot1 = new TreeNode(4, new TreeNode(1), new TreeNode(2));
        var result1 = solution.IsSubtree(root1, subRoot1);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var root2 = new TreeNode(3, new TreeNode(4, new TreeNode(1), new TreeNode(2)), new TreeNode(5));
        var subRoot2 = new TreeNode(4, new TreeNode(1), new TreeNode(2, new TreeNode(0), null));
        var result2 = solution.IsSubtree(root2, subRoot2);
        Console.WriteLine("Result for case 2: " + result2);
    }
}