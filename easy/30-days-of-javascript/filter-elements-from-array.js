//Sixth problem from '30 days of JavaScript':
//Time complexity: O(n)
var filter = function(arr, fn) {
    let filteredArr = [];
    for(let i=0; i<arr.length; i++) {
        if(fn(arr[i], i)) {
            filteredArr.push(arr[i]);
        }
    }
    return filteredArr;
}

//Case 1:
let arr = [0, 10, 20, 30];
let fn = function graterThan10(n) { return n > 10 }
const newArray = filter(arr, fn);
console.log(`Result for case 1: [${newArray}]`);

//Case 2:
let arr2 = [1, 2, 3];
let fn2 = function firstIndex(n, i) { return i === 0; }
const newArray2 = filter(arr2, fn2);
console.log(`Result for case 2: [${newArray2}]`);

//Case 3:
let arr3 = [-2, -1, 0, 1, 2];
let fn3 = function plusOne(n) { return n + 1 }
const newArray3 = filter(arr3, fn3);
console.log(`Result for case 3: [${newArray3}]`);