//Ninth problem from '30 days of JavaScript' - Return length of arguments passed:
//Time complexity: O(1)
var argumentsLength = function(...args) {
    let result = args.length;
    return result;
};

//Case 1:
let args = [5];
console.log(`Result for case 1: ${argumentsLength(5)}`);

//Case 2:
let args2 = [{}, null, "3"];
console.log(`Result for case 2: ${argumentsLength({}, null, "3")}`);