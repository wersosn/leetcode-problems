//Twenty-sixth problem from '30 days of JavaScript' - Flatten Deeply Nested Array:
//Time complexity: O(n * m), where n - the number of all elements in the most nested array, m - max depth (variable n)
var flat = function (arr, n) {
    const flatten = [];
    for(let i=0;i <arr.length; i++) { //loop throuh the value of the object
        let recu = flat(arr[i], n-1); //recursively call 'flat' on element 'arr[i]' and decrement 'n' by 1
        if(Array.isArray(arr[i]) && n>0) { //check if element 'i' is an array and depth > 0
            flatten.push(...recu); //add recu to the flatten
        }
        else {
            flatten.push(arr[i]); //add current element 'arr[i]' to the flatten
        }
    }
    return flatten;
};

//Case 1:
let arr = [1, 2, 3, [4, 5, 6], [7, 8, [9, 10, 11], 12], [13, 14, 15]];
let n = 0;
console.log("Result for case 1:");
console.log(flat(arr, n));

//Case 2:
let arr2 = [1, 2, 3, [4, 5, 6], [7, 8, [9, 10, 11], 12], [13, 14, 15]];
let n2 = 1;
console.log("Result for case 2:");
console.log(flat(arr2, n2));

//Case 3:
let arr3 = [[1, 2, 3], [4, 5, 6], [7, 8, [9, 10, 11], 12], [13, 14, 15]];
let n3 = 2;
console.log("Result for case 3:");
console.log(flat(arr3, n3));