//Path Sum III
//Solution: Use recursive approach to traverse the tree and find paths
//Time complexity: O(n^2)
function TreeNode(val, left, right) {
    this.val = (val === undefined ? 0 : val)
    this.left = (left === undefined ? null : left)
    this.right = (right === undefined ? null : right)
}

var pathSum = function (root, targetSum) {
    if (root === null) {  //if current root is empty - return null
        return null;
    }
    let paths = 0; //initialize path counter
    let sums = []; //initialize empty array to store sum

    var dfs = function (node, sum) { //depth first search algorithm
        if (node !== null) {  //if there is a node - continue
            sum.push(0); //add 0 as the beginning of the path for the current node
            for (let i = 0; i < sum.length; i++) { //iterate thourh sum array
                sum[i] += node.val; //add value of current node to the sum
                if (sum[i] === targetSum) { //if current sum is equal to targetSum:
                    paths++; //increment paths variable
                }
            }
            //recursively traverse both subtrees, passing a new copy of sum for the subtree
            dfs(node.left, [...sum]);
            dfs(node.right, [...sum]);
        }
    }
    dfs(root, sums); //start at the root
    return paths;
};

//Case 1:
root = [10,5,-3,3,2,null,11,3,-2,null,1], targetSum = 8;
pathSum(root, targetSum); //3

//Case 2:
root = [5,4,8,11,null,13,4,7,2,null,null,5,1], targetSum = 22;
pathSum(root, targetSum); //3
