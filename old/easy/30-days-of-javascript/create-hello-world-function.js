//First problem from '30 days of JavaScript':
//Time complexity: O(1)
var createHelloWorld = function () {
    return function (...args) {
        const x = "Hello World";
        return x;
    }
};

//Case 1:
const f = createHelloWorld();
const test = f();
console.log(`Result for case 1: ${test}`);

//Case 2:
const f2 = createHelloWorld();
const test2 = f2({}, null, 42);
console.log(`Result for case 2: ${test2}`);