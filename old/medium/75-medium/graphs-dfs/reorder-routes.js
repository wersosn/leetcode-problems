//Reorder Routes to Make All Paths Lead to the City Zero
//Solution: Use Depth First Search algorithm
//Time complexity: O(n+m)
//I used here solution by user Angielf (https://leetcode.com/problems/reorder-routes-to-make-all-paths-lead-to-the-city-zero/solutions/5168693/dfs-with-explanation)
var minReorder = function (n, connections) {
    let reorders = 0; // the number of reorders needed
    let adj = new Array(n).fill(null).map(() => []); //initialize the adjacency list
    for (let [from, to] of connections) { //build the adjacency list (from->to, for example: 0->1, 1->3 etc.)
        //let's use x and y as an example
        adj[from].push([to, 1]); //road from one node to another (x->y), need reordering (sign 1)
        adj[to].push([from, 0]); //reverse road from one node to another (y->x), doesn't need reordering (sign 0)
    }

    var dfs = function (node, parent) {
        for (let [neighbor, sign] of adj[node]) { //iterate over all neighbors of the current node
            if (neighbor !== parent) { //if current neighbour is not parent (avoid going back to the parent node (previously visited node))
                //if sign is 1, it means the direction is from parent to child, so it needs reordering
                //if sigh is 0, we don't change anything
                reorders += sign;
                dfs(neighbor, node); //recursively visit the neighbor, passing current node as the parent
            }
        }
    }

    dfs(0, -1); //start DFS from node 0, with -1 as the parent (no parent for the root)

    return reorders;
};

//Case 1:
n = 6, connections = [[0, 1], [1, 3], [2, 3], [4, 0], [4, 5]];
console.log(`Result for case 1: ${minReorder(n, connections)}`);

//Case 2:
n = 5, connections = [[1, 0], [1, 2], [3, 2], [3, 4]];
console.log(`Result for case 2: ${minReorder(n, connections)}`);

//Case 3:
n = 3, connections = [[1, 0], [2, 0]];
console.log(`Result for case 3: ${minReorder(n, connections)}`);