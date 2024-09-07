//Maximum Depth of Binary Tree
//Solution: Use recursive approach to traverse the tree
//Time complexity: O(n)
function TreeNode(val, left, right) {
    this.val = (val === undefined ? 0 : val)
    this.left = (left === undefined ? null : left)
    this.right = (right === undefined ? null : right)
}

var maxDepth = function (root) {
    let depth = 0;
    if (root === null) { //if current root is empty - return null
        return null;
    }
    //recursively call maxDepth:
    let left = maxDepth(root.left); //find the depth of the left side of the tree
    let right = maxDepth(root.right); //find the depth of the right side of the tree
    depth = Math.max(left, right) + 1; //find maximum depth
    return depth;
};

//Case 1:
root = [3,9,20,null,null,15,7];
maxDepth(root);

//Case 2:
root2 = [1,null,2];
maxDepth(root2);

