// Pattern: Iterative in-order traversal
// When to use: When a BST's values must be processed in sorted order, such as finding the kth smallest value.
// Complexity: O(h + k) time and O(h) space, where h is the tree height.

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
    public int KthSmallest(TreeNode root, int k) {
        if(root == null || k < 0) {
            return 0;
        }

        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        int min = current.val;
        int count = 0;

        while(current != null || stack.Count > 0) {
            while(current != null) {
                stack.Push(current);
                current = current.left;
            }
            current = stack.Pop();

            count++;    
            if(count == k) {
                min = current.val;
                break;
            }
            
            current = current.right;
        }
        return min;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        //Case 1:
        var result1 = solution.KthSmallest(new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4)));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.KthSmallest(new TreeNode(5, new TreeNode(3, new TreeNode(2, new TreeNode(1)), new TreeNode(4)), new TreeNode(6)));
        Console.WriteLine("Result for case 2: " + result2);
    }
}