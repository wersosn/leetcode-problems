//Twenty-fifth problem from '30 days of JavaScript':
//Time complexity: O(nlogn)
var join = function(arr1, arr2) {
    let array = [];
    array = arr1.concat(arr2); //merge two arrays into one
    let merged = {}; //initialize an empty object that will be a container for merged objects
    array.forEach((object) => {const id = object.id; //create id variable
    //if object share the same id - marge their properties:
    if(merged[id]) {
        merged[id] = {...merged[id], ...object }; //copy the properties of existing object (...merged[id]) and then overriding them with the properties of the current object (...obj)
    }
    //else if id exists in only one array - the single object with that id should be included :
    else {
        merged[id] = { ...object }; //add a new key-value pair to the merged (key - id, value - copy of the current object)
    }
    });
    let joinedArray = Object.values(merged); //extract the values from merged
    joinedArray.sort((x, y) => x.id - y.id); //sort the array in ascending order
    return joinedArray;
};

//Case 1:
let arr1 = [
    {"id": 1, "x": 1},
    {"id": 2, "x": 9}
], 
arr2 = [
    {"id": 3, "x": 5}
];
console.log("Result for case 1:");
console.log(join(arr1, arr2));

//Case 2:
let arr3 = [
    {"id": 1, "x": 2, "y": 3},
    {"id": 2, "x": 3, "y": 6}
], 
arr4 = [
    {"id": 2, "x": 10, "y": 20},
    {"id": 3, "x": 0, "y": 0}
];
console.log("Result for case 2:");
console.log(join(arr3, arr4));

//Case 3:
let arr5 = [
    {"id": 1, "b": {"b": 94},"v": [4, 3], "y": 48}
],
arr6 = [
    {"id": 1, "b": {"c": 84}, "v": [1, 3]}
];
console.log("Result for case 3:");
console.log(join(arr5, arr6));