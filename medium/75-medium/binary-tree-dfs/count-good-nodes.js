//Count Good Nodes in Binary Tree
//Solution: Use recursive approach to traverse the tree and get the number of good nodes
//Time complexity: O(n)
function TreeNode(val, left, right) {
    this.val = (val === undefined ? 0 : val)
    this.left = (left === undefined ? null : left)
    this.right = (right === undefined ? null : right)
}

var goodNodes = function (root) {
    let arr = []; //initialize an empty array to store "good" values
    let rootVal = root.val; //get value from root
    if (root === null) { //if current root is empty - return null
        return null;
    }

    var dfs = function (node, rootVal) { //depth first search algorithm
        if (node !== null) { //if there is a node - continue
            if (node.val >= rootVal) { //if value in current node is greater than or equal to the root value -> if's a "good" node
                arr.push(node.val); //add it to the array
            }
            let max = Math.max(node.val, rootVal); //update max value
            //recursively traverse both subtrees, passing the updated max value
            dfs(node.left, max);
            dfs(node.right, max);
        }
    }

    dfs(root, rootVal); //start at the root
    let good = arr.length; //get the number of good nodes
    return good;
};

//Case 1:
root = [3,1,4,3,null,1,5];
goodNodes(root); //4

//Case 2:
root = [3,3,null,4,2];
goodNodes(root); //3

//Case 3:
root = [1];
goodNodes(root); //1