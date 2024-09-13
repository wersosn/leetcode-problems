//Delete Node in a BST
//Solution: Recursively search the tree to find a node with a value equal to the key, remove it, and fix the tree
//Time complexity: O(n) - if the tree is unbalanced, O(logn) - if the tree is balanced
function TreeNode(val, left, right) {
    this.val = (val === undefined ? 0 : val)
    this.left = (left === undefined ? null : left)
    this.right = (right === undefined ? null : right)
}

var minChild = function (root) { //helper function to find the smallest child
    while (root.left !== null) { //iterate through the tree until you find the smallest node
        root = root.left;
    }
    return root;
};

var deleteNode = function (root, key) {
    if (root === null || key === null) { //if current root is empty or key = null - return null
        return null;
    }

    if (root.val === key) { //if current root is equal to key -> we found node to remove
        if (root.right === null && root.left === null) { //if the node has no children
            return null;
        }
        else if (root.left === null) { //if the node doesn't have left child
            return root.right; //replace it with the right child
        }
        else if (root.right === null) { //if node doesn't have right child
            return root.left; //replace it with the left child
        }
        else { //if node has both children
            let min = minChild(root.right); //find the smallest child in the right subtree
            root.val = min.val; //replace the value of the current node with the value of the found smallest child
            root.right = deleteNode(root.right, min.val); //remove this child from the right subtree
        }
    }
    else if (root.val > key) { //if current root is greater than the key:
        root.left = deleteNode(root.left, key); //move to the left
    }
    else if (root.val < key) { //if current root is smaller than the key:
        root.right = deleteNode(root.right, key); //move to the right
    }

    return root;
};

//Case 1:
root = [5, 3, 6, 2, 4, null, 7], key = 3;
deleteNode(root, key); //[5,4,6,2,null,null,7]

//Case 2:
root = [5, 3, 6, 2, 4, null, 7], key = 0;
deleteNode(root, key); //[5,3,6,2,4,null,7]

//Case 3:
root = [], key = 0;
deleteNode(root, key); //[]