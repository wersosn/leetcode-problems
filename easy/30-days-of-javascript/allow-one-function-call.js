//Tenth problem from '30 days of JavaScript':
//Time complexity: O(1)
var once = function(fn) {
    let call = false; //flag
    return function(...args){
        if(call === false) { //if the function was called for the first time
            call = true; //set flag to true
            return fn(...args); //return fn
        }
        else {
            return undefined; //else return undefined
        }
    }
};

//Case 1:
let fn = (a,b,c) => (a + b + c);
const result = once(fn);
console.log(`Result for case 1: ${result(1,2,3)}, ${result(2,3,6)}`);

//Case 2:
let fn2 = (a,b,c) => (a * b * c);
const result2 = once(fn2);
console.log(`Result for case 2: ${result2(5,7,4)}, ${result2(2,3,6)}, ${result2(4,6,8)}`);
