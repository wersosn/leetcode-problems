//Twenty-first problem from '30 days of JavaScript':
//Time complexity: O(n)
var chunk = function(arr, size) {
    let chunk = []; //create a new array
    if(arr.length < size) { //check if size is bigger than original length of array
        if(arr.length === 0) { //check if array is empty
            return []; //if so - return []
        }
        chunk[0] = arr; //else - all elements are in the first subarray
        return chunk;
    }
    //in other cases:
    for(let i=0; i<arr.length; i += size) {
        let newElement = arr.slice(i, i+size); //slice elements form index 0 to index + size
        chunk.push(newElement); //add new element to the array
    }
    return chunk;
};

//Case 1:
let arr = [1,2,3,4,5], size = 1;
console.log(`Result for case 1: [${chunk(arr, size)}]`);

//Case 2:
let arr2 = [1,9,6,3,2], size2 = 3;
console.log(`Result for case 2: [${chunk(arr2, size2)}]`);

//Case 3:
let arr3 = [8,5,3,2,6], size3 = 6;
console.log(`Result for case 3: [${chunk(arr3, size3)}]`);

//Case 4:
let arr4 = [], size4 = 1;
console.log(`Result for case 4: [${chunk(arr4, size4)}]`);