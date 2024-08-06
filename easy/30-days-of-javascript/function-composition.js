//Eighth problem from '30 days of JavaScript':
//Time complexity: O(n)
var compose = function(functions) {
    
    return function(x) {
        if(functions.length === 0) {
            return x;
        }
        else {
            functions.reverse(); //reverse the array with functions
            for(let i=0; i<functions.length; i++) { //loop through them   
                x = functions[i](x);
            }
            return x;
        }
    }
};

//Case 1:
let result = compose([x => x + 1, x => x * x, x => 2 * x]);
console.log(`result for case 1: ${result(4)}`);

//Case 2:
let result2 = compose([x => 10 * x, x => 10 * x, x => 10 * x]);
console.log(`result for case 1: ${result2(1)}`);

//Case 3:
let result3 = compose([]);
console.log(`result for case 1: ${result3(42)}`);