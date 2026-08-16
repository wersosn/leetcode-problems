//Longest ZigZag Path in a Binary Tree
//Solution: Use recursive approach to traverse the tree and find longest ZigZag
//Time complexity: O(n)
function TreeNode(val, left, right) {
    this.val = (val === undefined ? 0 : val)
    this.left = (left === undefined ? null : left)
    this.right = (right === undefined ? null : right)
}

var longestZigZag = function(root) {
    if(root === null) { //if current root is empty - return null
        return null;
    }

    let longestZigZag = 0; //initialize a variable to store the longest zigzag length

    var dfs = function(node, direction, steps) { //depth first search algorithm; direction -> which way are we going, steps -> number of steps taken so far (zigzag length)
        if(node !== null) { //if there is a node - continue
            if(steps > longestZigZag) {  //if current steps (zigzag length) is greater than longestZigZag 
                longestZigZag = steps; //update longestZigZag 
            }

            if(direction === 'left') { //if current direction is 'left'
                dfs(node.left, 'right', steps + 1); //move to the right and add one step (continue zigzag)
                dfs(node.right, 'left', 1); //move to the left - then restart and start a new path to the right
            }
            else if(direction === 'right') { //if current direction is 'right'
                dfs(node.right, 'left', steps + 1); //move to the left and add one step (continue zigzag)
                dfs(node.left, 'right', 1); //move to the right - then restart and start a new path to the left
            }
        }
    }
    //start from the left and right sides of the tree
    dfs(root.left, 'right', 1);
    dfs(root.right, 'left', 1);

    return longestZigZag;
};

//Case 1:
root = [1,null,1,1,1,null,null,1,1,null,1,null,null,null,1];
longestZigZag(root); //3

//Case 2:
root = [1,1,1,null,1,null,null,1,1,null,1];
longestZigZag(root); //4

//Case 3:
root = [1];
longestZigZag(root); //0