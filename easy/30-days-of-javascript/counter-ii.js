//Fourth problem from '30 days of JavaScript':
//Time complexity: O(1)
var createCounter = function(init) {
    const result = init; //variable for holding initial value
    let object = {
        increment: function() { //increases the current value by 1 and then returns it
            ++init;
            return init;
        },
        reset: function() { //sets the current value to init and then returns it
            init = result;
            return init;
        },
        decrement: function() { //reduces the current value by 1 and then returns it
            --init;
            return init;
        }
    } 
    return object;
};

//Case 1:
const counter = createCounter(5);
let a = counter.increment();
let b = counter.reset();
let c = counter.decrement();
console.log(`Result for case 1: [${a}, ${b}, ${c}]`);

//Case 2:
const counter2 = createCounter(0);
let x = counter2.increment();
let x2 = counter2.increment();
let y = counter2.decrement();
let z = counter2.reset();
let z2 = counter2.reset();
console.log(`Result for case 2: [${x}, ${x2}, ${y}, ${z}, ${z2}]`);
