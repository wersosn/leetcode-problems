//Third problem from '30 days of JavaScript':
//Time complexity: O(1)
var expect = function(val) {
    let object = { //creating object, that will return the appropriate function
        toBe: function(value) { //function for checking if two values are equal
            if(val === value) {
                return true;
            }
            else {
                return "Not Equal"; //for testing
                throw new Error("Not Equal"); //error is required in the task instead of return
            }
        },
        notToBe: function(value) { //function for checking if two values are not equal
            if(val !== value) {
                return true;
            }
            else {
                return "Equal"; //for testing
                throw new Error("Equal"); //error is required in the task instead of return
            }
        }
    }
    return object;
};

//Case 1:
let r = expect(5).toBe(5);
console.log(`Result for case 1: ${r}`);

//Case 2:
let r2 = expect(5).toBe(null);
console.log(`Result for case 2: ${r2}`);

//Case 3:
let r3 = expect(5).notToBe(null);
console.log(`Result for case 3: ${r3}`);

//Case 4:
let r4 = expect(5).notToBe(5);
console.log(`Result for case 4: ${r4}`);
