//Equal Row and Column Pairs
//Solution: Use map to store the string representations of rows and their frequencies
//Time-complexity: O(n^2)
var equalPairs = function (grid) {
    let count = 0;
    let rows = new Map(); //a map to store the string representations of rows and their frequencies

    for (let i = 0; i < grid.length; i++) {
        const row = grid[i].join(','); //convert the current row into a string
        rows.set(row, (rows.get(row) || 0) + 1); //store the row in the map and increment its count
    }

    for (let i = 0; i < grid.length; i++) { //create column strings and compare with the rows
        let col = []; //temporary array to collect elements of the current column
        for (let j = 0; j < grid.length; j++) {
            col.push(grid[j][i]); //add current column element to the array
        }
        const colString = col.join(','); //convert the column into a string

        if (rows.has(colString)) { //check if the string representation of the column exists in the map
            count += rows.get(colString); //if so -> add the frequency count to the total count
        }
    }

    return count;
};

//Case 1:
grid = [[3,2,1],[1,7,6],[2,7,7]];
console.log(`Result for case 1: ${equalPairs(grid)}`);

//Case 2:
grid = [[3,1,2,2],[1,4,4,5],[2,4,2,2],[2,4,2,2]];
console.log(`Result for case 2: ${equalPairs(grid)}`);