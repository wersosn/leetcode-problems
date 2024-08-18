//Twenty-seventh problem from '30 days of JavaScript':
//Time complexity: O(n) - for arrays, O(k) for objects 
//I used here the explanation of this problem by user TheGElCOgecko
var compactObject = function (obj) {
    if (!obj) { //if obj is false - return false
        return false;
    }
    if (typeof obj !== 'object') { //if obj is not an object - return obj
        return obj;
    }
    if (Array.isArray(obj)) { //if obj is an array
        return obj.filter(Boolean).map(compactObject); //filter out falsy values, then recursively call compactObject on each remaining element
    }

    let compact = {}; //create new compact object
    for (const key in obj) { //iterate through each key
        let val = compactObject(obj[key]); //call compactObject for each key's value
        if(val) { //if value is true
            compact[key] = val; //add value to the object
        }
    }
    return compact;
};

//Case 1:
let obj = [null, 0, false, 1];
console.log("Result for case 1: ");
console.log(compactObject(obj));

//Case 2:
let obj2 = {"a": null, "b": [false, 1]};
console.log("Result for case 2: ");
console.log(compactObject(obj2));

//Case 3:
let obj3 = [null, 0, 5, [0], [false, 16]];
console.log("Result for case 3: ");
console.log(compactObject(obj3));