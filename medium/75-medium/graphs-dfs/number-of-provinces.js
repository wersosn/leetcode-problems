//Number of Provinces
//Solution: Use Depth First Search algorithm
//Time complexity: O(n^2)
var findCircleNum = function (isConnected) {
    let provinces = 0; //number of provinces (directly or indirectly connected cities)
    let visited = []; //array to keep track of visited nodes
    for (let i = 0; i < isConnected.length; i++) { //iterate through all of the nodes
        if (!visited.includes(i)) { //check if current city has already been visited, if not:
            provinces++; //increment number of provinces
            dfs(i, isConnected, visited); //start dfs to mark all connected cities
        }
    }
    return provinces; //return the total number of provinces
};

var dfs = function (node, isConnected, visited) {
    visited.push(node); //add current node to visited
    for (let i = 0; i < isConnected.length; i++) { //check each city to see if it's directly connected to the current city
        if (isConnected[node][i] && !visited.includes(i)) { //if there's a connection and the city hasn't been visited yet
            dfs(i, isConnected, visited); //recursively visit all connected cities
        }
    }
};

//Case 1:
isConnected = [[1, 1, 0], [1, 1, 0], [0, 0, 1]];
console.log(`Result for case 1: ${findCircleNum(isConnected)}`);

//Case 2:
isConnected = [[1, 0, 0], [0, 1, 0], [0, 0, 1]];
console.log(`Result for case 2: ${findCircleNum(isConnected)}`);