// Pattern: Recursive depth-first search (DFS)
// When to use: Comparing two tree structures and their corresponding node values
// Complexity: O(n) time and O(h) space, where n is the number of nodes checked and h is the tree height

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
        var result1 = solution.IsSameTree(new TreeNode(1, new TreeNode(2), new TreeNode(3)), new TreeNode(1, new TreeNode(2), new TreeNode(3)));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.IsSameTree(new TreeNode(1, new TreeNode(2)), new TreeNode(1, null, new TreeNode(2)));
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.IsSameTree(new TreeNode(1, new TreeNode(2),new TreeNode(1)), new TreeNode(1, new TreeNode(1), new TreeNode(2)));
        Console.WriteLine("Result for case 3: " + result3);
    }
}