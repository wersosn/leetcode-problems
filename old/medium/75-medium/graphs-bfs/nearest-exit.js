//Nearest Exit from Entrance in Maze
//Solution: Find the shortest path from the entrance to the nearest exit in a maze using the BFS algorithm
//Time complexity: O(n*m) -> n - rows, m - columns
//I used here solution by user gnoman (https://leetcode.com/problems/nearest-exit-from-entrance-in-maze/solutions/3952021/js-graph-bfs-w-intuitive-comments)
var nearestExit = function (maze, entrance) {
    var isValid = function (row, col) { //helper function to check if the position is valid (inside the maze and not a wall)
        if (row >= 0 && col >= 0 && row < height && col < width && maze[row][col] === '.') {
            return true; //if all conditions are met - return true
        } else {
            return false;
        }
    }

    var isExit = function (row, col) { //helper function to check if the position is an exit
        if ((row === 0 || col === 0 || row === height - 1 || col === width - 1) && maze[row][col] === '.') {
            return true; //if all conditions are met - return true
        } else {
            return false;
        }
    }

    let height = maze.length, width = maze[0].length; //dimensions of the maze
    let steps = 0; //counter for steps
    let visited = Array.from({ length: height }, () => Array(width).fill(false)); //array for tracking visited cells
    let queue = [entrance];  //start BFS from the entrance
    let directions = [[0, 1], [1, 0], [0, -1], [-1, 0]]; //possible movement directions (right, down, left, up)
    visited[entrance[0]][entrance[1]] = true; //mark entrance as visited

    while (queue.length > 0) { //BFS - breadth-first search
        let nextQueue = []; //array to store the cells to visit in the next step
        steps++; //because our entrance is not an exit, we have to take a step
        for (let [row, col] of queue) { //process each cell in the current queue
            for (const [x, y] of directions) { //check all four directions
                let nextRow = row + x; //calculate next row
                let nextCol = col + y; //calculate next column

                if (isValid(nextRow, nextCol) && !visited[nextRow][nextCol]) { //check if the next position is valid and not visited
                    if (isExit(nextRow, nextCol)) { //if the next position is an exit
                        return steps; //return number of steps
                    }
                    visited[nextRow][nextCol] = true; //mark the cell as visited
                    nextQueue.push([nextRow, nextCol]); //add it to the next queue
                }
            }
        }
        queue = nextQueue; //move to the next level of BFS
    }
    return -1; //if no such path exists - return -1
};

//Case 1:
maze = [["+","+",".","+"],[".",".",".","+"],["+","+","+","."]], entrance = [1,2];
console.log(`Result for case 1: ${nearestExit(maze, entrance)}`);

//Case 2:
maze = [["+","+","+"],[".",".","."],["+","+","+"]], entrance = [1,0];
console.log(`Result for case 2: ${nearestExit(maze, entrance)}`);

//Case 3:
maze = [[".","+"]], entrance = [0,0];
console.log(`Result for case 3: ${nearestExit(maze, entrance)}`);