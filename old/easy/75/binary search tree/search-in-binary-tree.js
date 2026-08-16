//Search in a Binary Search Tree
//Solution: Iterate through the tree until you find the node or reach a leaf
//Time complexity: O(n) - if the tree is unbalanced, O(logn) - if the tree is balanced
function TreeNode(val, left, right) {
    this.val = (val === undefined ? 0 : val)
    this.left = (left === undefined ? null : left)
    this.right = (right === undefined ? null : right)
}

var searchBST = function (root, val) {
    if (root === null || val === null) { //if current root is empty or value = null - return null
        return null;
    }

    while (root !== null) { //iterate through the tree until you find the node or reach a leaf
        if (root.val === val) { //if current node's value is the same as target value
            return root; //return subtree rooted with that node
        }
        else if (root.val < val) { //if current node's value is less than the target value -> move to the right subtree
            root = root.right;
        }
        else { //if current node's value is greater than the target value -> move to the left subtree
            root = root.left;
        }
    }

    return null; //if such node does not exist - return null
};

//Case 1:
root = [4, 2, 7, 1, 3], val = 2;
searchBST(root, val); //[2,1,3]

//Case 2:
root = [4, 2, 7, 1, 3], val = 5;
searchBST(root, val); //[]