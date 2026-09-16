// Pattern: Iterative inorder traversal with run-length counting
// When to use: Finding the most frequent value(s) in a BST, where inorder traversal visits equal values consecutively
// Complexity: O(n) time, O(h + k) space, where h is the tree height and k is the number of modes

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
    public int[] FindMode(TreeNode root) {
        if(root == null) {
            return new int[0];
        }

        List<int> result = new List<int>();

        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        int count = 0, maxCount = 0;
        TreeNode prev = null;

        while(current != null || stack.Count > 0) {
            while(current != null) {
                stack.Push(current);
                current = current.left;
            }
            current = stack.Pop();
            if(prev == null || prev.val == current.val) {
                count++;
            }
            else {
                count = 1;
            }
        
            if(count > maxCount) {
                result.Clear();
                maxCount = count;
                result.Add(current.val);
            }
            else if(count == maxCount) {
                result.Add(current.val);
            }
            
            prev = current;
            current = current.right;
        }
        return result.ToArray();
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        //Case 1:
        var result1 = solution.FindMode(new TreeNode(1, null, new TreeNode(2, new TreeNode(2))));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.FindMode(new TreeNode(0));
        Console.WriteLine("Result for case 2: " + result2);
    }
}
