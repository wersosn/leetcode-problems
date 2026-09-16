// Pattern: Breadth-First Search (BFS) / Level-order traversal
// When to use: When you need to visit nodes level by level, or process a tree in layers from top to bottom.
// Complexity: O(n) time, O(w) space, where w is the maximum width of the tree (worst case O(n)).

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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if(root == null) {
            return new List<IList<int>>();
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        IList<IList<int>> result = new List<IList<int>>();

        while(queue.Count > 0) {
            int size = queue.Count;
            IList<int> level = new List<int>();
            for(int i = 0; i < size; i++) {
                TreeNode node = queue.Dequeue();
                level.Add(node.val);

                if(node.left != null) {
                    queue.Enqueue(node.left);
                }

                if(node.right != null) {
                    queue.Enqueue(node.right);
                }
            }
            result.Add(level);
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
        var result1 = solution.LevelOrder(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.LevelOrder(new TreeNode(1));
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.LevelOrder(null);
        Console.WriteLine("Result for case 3: " + result3);
    }
}