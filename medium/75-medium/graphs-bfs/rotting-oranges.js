//Rotting Oranges
//Solution: Use breadth-first search (BFS) to spread rot from initially rotten oranges to their fresh neighbors and return the time it takes for all oranges to rot.
//Time complexity: O(n*m) -> n - rows, m - columns
//I used here solution by user casmith1987 (https://leetcode.com/problems/rotting-oranges/solutions/1858396/javascript-clean-bfs-w-explanation-99-5)
var orangesRotting = function (grid) {
    let queue = []; //queue for BFS (breadth-first search)
    let time = 0, orang = 0; //time and fresh oranges
    let rows = grid.length; //number of rows in the grid
    let cols = grid[0].length; //number of columns in the grid
    let directions = [[0, 1], [1, 0], [0, -1], [-1, 0]]; //possible movement directions (right, down, left, up)

    //traverse the grid to count fresh oranges and add rotten ones to the queue
    for (let i = 0; i < rows; i++) { //traverse rows
        for (let j = 0; j < cols; j++) { //traverse columns
            if (grid[i][j] === 1) { //check if orange is fresh, if so:
                orang++; //increment orange count
            }
            else if (grid[i][j] === 2) { //check if orange is rotten, if so:
                queue.push([i, j, 0]); //add it to the queue
            }
        }
    }

    //perform BFS to propagate the rotting process
    while (queue.length && orang) { //loop until queue is not empty and there are still fresh oranges
        const [curR, curC, minutes] = queue.shift(); //take the current rotten orange from the queue
        if (grid[curR][curC] === 1) { //if orange is still fresh
            grid[curR][curC] = 2; //change it to rotten
            orang--; //decrement orange count
            time = minutes; //update the time to the current minutes passed
        }

        //check neighboring cells (right, down, left, up)
        for (let pair of directions) {
            const x = pair[0];
            const y = pair[1];
            const [newR, newC] = [curR + x, curC + y]; //calculate the new row and column
            if (newR < 0 || newR > rows - 1 || newC < 0 || newC > cols - 1) { //skip if the new position is out of bounds
                continue;
            }
            if (grid[newR][newC] === 1) { //if the neighboring cell contains a fresh orange
                queue.push([newR, newC, minutes + 1]); //add it to the queue
            }
        }
    }
    if (orang) { //if there are still fresh oranges left (not all oranges can be rotted)
        return -1;
    }
    else { //else if all oranges are rotten
        return time; //return the time taken to rot all oranges
    }
};

//Case 1:
grid = [[2, 1, 1], [1, 1, 0], [0, 1, 1]];
console.log(`Result for case 1: ${orangesRotting(grid)}`);

//Case 2:
grid = [[2, 1, 1], [0, 1, 1], [1, 0, 1]];
console.log(`Result for case 2: ${orangesRotting(grid)}`);

//Case 3:
grid = [[0, 2]];
console.log(`Result for case 3: ${orangesRotting(grid)}`);