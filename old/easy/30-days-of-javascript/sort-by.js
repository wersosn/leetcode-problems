//Twenty-fourth problem from '30 days of JavaScript':
//Time complexity: O(nlogn)
var sortBy = function(arr, fn) {
    let sortedArr = [];
    sortedArr = arr.sort((a, b) => fn(a) - fn(b)); //sort, by comparing two elements and subtracting the result of fn(b) from fn(a) to get the final result
    return sortedArr;
};

//Case 1:
let arr = [5,4,1,2,3];
let fn = (x) => x;
console.log(`Result for case 1: [${sortBy(arr, fn)}]`);

//Case 2:
let arr2 = [{"x": 1}, {"x": 0}, {"x": -1}];
let fn2 = (d) => d.x;
let result = sortBy(arr2, fn2);
console.log("Result for case 2: ");
console.log(result);

//Case 3:
let arr3 = [[3, 4], [5, 2], [10, 1]];
let fn3 = (x) => x[1];
console.log(`Result for case 3: [${sortBy(arr3, fn3)}]`);