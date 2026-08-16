//Fifth problem from '30 days of JavaScript' - Apply transform over each element in array:
//Time complexity: O(n)
var map = function(arr, fn) {
    let newArray = [];
    for(let i=0; i<arr.length; i++) {
        newArray[i] = fn(arr[i], i); 
    }
    return newArray;
};

//Case 1:
let arr = [1,2,3];
let fn = function plusone(n) { return n+1; };
const newArray = map(arr, fn);
console.log(`Result for case 1: [${newArray}]`);

//Case 2:
let arr2 = [1,2,3];
let fn2 = function pluI(n, i) { return n+i; };
const newArray2 = map(arr2, fn2);
console.log(`Result for case 2: [${newArray2}]`);

//Case 3:
let arr3 = [10,20,30];
let fn3 = function constant() { return 42; };
const newArray3 = map(arr3, fn3);
console.log(`Result for case 3: [${newArray3}]`);