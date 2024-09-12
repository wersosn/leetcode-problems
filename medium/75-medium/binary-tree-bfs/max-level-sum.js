//Maximum Level Sum of a Binary Tree
//Solution: Use recursive approach to traverse both substrees and calculate sum on current level
//Time complexity: O(n)
function TreeNode(val, left, right) {
    this.val = (val === undefined ? 0 : val)
    this.left = (left === undefined ? null : left)
    this.right = (right === undefined ? null : right)
}

var maxLevelSum = function (root) {
    if (root === null) { //if current root is empty - return null
        return null;
    }
    let maxLevel = 0;
    let sum = []; //array to store sum of each level
    let max = -Infinity;

    var bfs = function (node, level) { //breadth-first search algorithm
        if (node !== null) {
            if (sum.length <= level) { //initialize sum for this level
                sum[level] = 0;
            }
            sum[level] += node.val; //add the node's value to the current level's sum

            //recursively traverse the left and right subtrees on the next level
            bfs(node.left, level + 1);
            bfs(node.right, level + 1);
        }
    }

    bfs(root, 0); //start at the root
    for (let i = 0; i < sum.length; i++) { //find the level with the maximum sum
        if (sum[i] > max) {
            max = sum[i]; //update max sum
            maxLevel = i + 1; //update max level
        }
    }

    return maxLevel;
};

//Case 1:
root = [1, 7, 0, 7, -8, null, null];
maxLevelSum(root); //2

//Case 2:
root = [989, null, 10250, 98693, -89388, null, null, null, -32127];
maxLevelSum(root); //2