//Twenty-third problem from '30 days of JavaScript':
//Time complexity: O(n)
Array.prototype.groupBy = function(fn) {
    let object = {}; //create an object
    for(let i=0; i<this.length; i++) { //iterate of each element in the array
        const key = fn(this[i]); //create a key
        if(!object[key]) { //check if the key already exists on the object
            object[key] = []; //set the value to be an empty array
        }
        object[key].push(this[i]); //push the value onto the array at the key
    }
    return object;
};

//Case 1:
let array = [
    {"id":"1"},
    {"id":"1"},
    {"id":"2"}
  ]
let fn = function (item) { 
    return item.id; 
  }
console.log("Result for case 1: ");
console.log(array.groupBy(fn));

//Case 2:
let array2 = [
    [1, 2, 3],
    [1, 3, 5],
    [1, 5, 9]
  ]
let fn2 = function (list) { 
    return String(list[0]); 
  }
console.log("Result for case 2: ");
console.log(array2.groupBy(fn2));

//Case 3:
let array3 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
let fn3 = function (n) { 
  return String(n > 5);
}
console.log("Result for case 3: ");
console.log(array3.groupBy(fn3));