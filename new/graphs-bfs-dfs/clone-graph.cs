// Pattern: Graph traversal (iterative DFS) with a node-to-clone hash map
// When to use: When cloning a graph while preserving cycles and shared neighbors
// Complexity: O(V + E) time and O(V) space, where V is the number of vertices (nodes) and E is the number of edges

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution
{
    public Node CloneGraph(Node node)
    {
        if (node == null)
        {
            return node;
        }

        Dictionary<Node, Node> clones = new Dictionary<Node, Node>();
        Stack<Node> stack = new Stack<Node>();

        Node clone = new Node(node.val);
        clones.Add(node, clone);
        stack.Push(node);

        while (stack.Count > 0)
        {
            Node current = stack.Pop();
            foreach (Node neighbor in current.neighbors)
            {
                if (!clones.ContainsKey(neighbor))
                {
                    Node neighborClone = new Node(neighbor.val);
                    clones.Add(neighbor, neighborClone);
                    stack.Push(neighbor);
                }
                clones[current].neighbors.Add(clones[neighbor]);
            }
        }
        return clones[node];
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        //Case 1:
        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);

        node1.neighbors.Add(node2);
        node1.neighbors.Add(node4);

        node2.neighbors.Add(node1);
        node2.neighbors.Add(node3);

        node3.neighbors.Add(node2);
        node3.neighbors.Add(node4);

        node4.neighbors.Add(node1);
        node4.neighbors.Add(node3);

        var result1 = solution.CloneGraph(node1);
        Console.WriteLine("Result for case 1: " + result1.val);

        //Case 2:
        var node5 = new Node(1);
        var result2 = solution.CloneGraph(node5);
        Console.WriteLine("Result for case 2: " + result2.val);

        //Case 3:
        var result3 = solution.CloneGraph(null);
        Console.WriteLine("Result for case 3: " + result3.val);
    }
}