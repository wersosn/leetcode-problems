//Leaf-Similar Trees
//Solution: Use recursive approach to traverse both trees
//Time complexity: O(n)
function TreeNode(val, left, right) {
    this.val = (val === undefined ? 0 : val)
    this.left = (left === undefined ? null : left)
    this.right = (right === undefined ? null : right)
}

var leafSimilar = function (root1, root2) {
    //initialize an empty array to store leaf values:
    let arr1 = []; //first tree
    let arr2 = []; //second tree
    if (root1 === null || root2 === null) { //if either root is null, return null
        return null;
    }

    dfs(root1, arr1); //perform DFS on the first tree and collect leaf values into arr1
    dfs(root2, arr2); //perform DFS on the second tree and collect leaf values into arr2

    if (arr1.length !== arr2.length) { //if the arrays have different lengths
        return false; //return false (trees are not leaf-similar)
    }
    for (let i = 0; i < arr1.length; i++) { //compare each element in both leaf arrays
        if (arr1[i] !== arr2[i]) { //if there are different elements
            return false; //return false (trees are not leaf-similar)
        }
    }
    return true; //else - return true (trees are leaf-similar)
};

var dfs = function (node, leaf) { //depth first search algorithm
    if (node !== null) { //if there is a node - continue
        if (node.left === null && node.right === null) { //if the node is a leaf node (has no left or right child)
            leaf.push(node.val); //add it to the array
        }
        //recursively traverse both subtrees
        dfs(node.left, leaf);
        dfs(node.right, leaf);
    }
}

//Case 1:
root1 = [3,5,1,6,2,9,8,null,null,7,4], root2 = [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8];
leafSimilar(root1, root2); //true

//Case 2:
root1 = [1,2,3], root2 = [1,3,2];
leafSimilar(root1, root2); //false