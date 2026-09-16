// Pattern: Iterative depth-first search (DFS) with an explicit stack
// When to use: To traverse a binary tree in preorder: root, left subtree, right subtree
// Complexity: O(n) time and O(h) space, where n is the number of nodes and h is the tree height

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
    public IList<int> PreorderTraversal(TreeNode root) {
        if(root == null) {
            return new List<int>();
        }

        IList<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while(stack.Count > 0) {
            TreeNode current = stack.Pop();
            result.Add(current.val);
            if(current.right != null) {
                stack.Push(current.right);
            }
            if(current.left != null) {
                stack.Push(current.left);
            }
        }
        return result;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        //Case 1:
        var result1 = solution.PreorderTraversal(new TreeNode(1, null, new TreeNode(2, new TreeNode(3))));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.PreorderTraversal(new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5, new TreeNode(6), new TreeNode(7))), new TreeNode(3, new TreeNode(8, new TreeNode(9)))));
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.PreorderTraversal(null);
        Console.WriteLine("Result for case 3: " + result3);

        //Case 4:
        var result4 = solution.PreorderTraversal(new TreeNode(1));
        Console.WriteLine("Result for case 4: " + result4);
    }
}
