//Second problem from '30 days of JavaScript':
//Time complexity: O(1)
var createCounter = function(n) {
    return function() {
        let x = n;
        ++n;
        return x;
    }
};

//Case 1:
const counter = createCounter(10);
let one = counter();
let two = counter();
let three = counter();
console.log(`Result = [${one}, ${two}, ${three}]`);

//Case 2:
const counter2 = createCounter(-2);
let a = counter2();
let b = counter2();
let c = counter2();
let d = counter2();
let e = counter2();
console.log(`Result = [${a}, ${b}, ${c}, ${d}, ${e}]`);