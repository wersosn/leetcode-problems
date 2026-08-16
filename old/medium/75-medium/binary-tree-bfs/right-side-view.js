//Binary Tree Right Side View
//Solution: Use recursive approach to traverse both substrees and overwrite a value if it already exists at that level
//Time complexity: O(n)
//I used here solution by user etairl (https://leetcode.com/problems/binary-tree-right-side-view/solutions/549960/javascript-52ms-dfs)
function TreeNode(val, left, right) {
    this.val = (val === undefined ? 0 : val)
    this.left = (left === undefined ? null : left)
    this.right = (right === undefined ? null : right)
}

var rightSideView = function (root) {
    if (root === null) { //if current root is empty - return empty array
        return [];
    }
    let arr = []; //initialize an empty array to store the rightmost view of the tree

    var bfs = function (node, height) { //breadth-first search algorithm; height -> corresponding level
        if (node !== null) { //if there is a node - continue
            arr[height] = node.val; //store the current node's value in the array
            bfs(node.left, height + 1); //explore the left subtree
            bfs(node.right, height + 1); //explore the right subtree (this ensures that the rightmost node at each level is preserved)
        }
    }

    bfs(root, 0); //start at the root with height = 0
    return arr;
};

//Case 1:
root = [1, 2, 3, null, 5, null, 4];
rightSideView(root); //[1,3,4]

//Case 2:
root = [1, null, 3];
rightSideView(root); //[1,3]

//Case 3:
root = [];
rightSideView(root); //[]