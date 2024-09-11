//Lowest Common Ancestor of a Binary Tree
//Solution: Use recursive approach to traverse both substrees and find lowest common ancestor
//Time complexity: O(n)
function TreeNode(val) {
    this.val = val;
    this.left = this.right = null;
}

var lowestCommonAncestor = function (root, p, q) {
    if (root === null) { //if current root is empty - return null
        return null;
    }
    if (root === p || root === q) { //if the current node is either p or q, return the current node
        return root; //it means we found either p or q in the current subtree!
    }

    //repeat the operation on the left and right subtrees to find p and q
    const left = lowestCommonAncestor(root.left, p, q);
    const right = lowestCommonAncestor(root.right, p, q);

    if (!left) { //if p and q are both found in the right subtree (left = null)
        return right; //return right
    }
    if (!right) { //if p and q are both found in the left subtree (right = null)
        return left; //return left
    }

    //if p is found in one subtree and q is found in the other, the current node (root) is the lowest common ancestor (LCA)
    return root;
};

//Case 1:
root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 1;
lowestCommonAncestor(root, p, q); //3

//Case 2:
root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 4;
lowestCommonAncestor(root, p, q); //5

//Case 3:
root = [1,2], p = 1, q = 2;
lowestCommonAncestor(root, p, q); //1