//Eleventh problem from '30 days of JavaScript':
//Time complexity: O(n)
//To solve this problem, I used the explanation of the problem by user vermaamanmr
function memoize(fn) {
    const cache = {}; //cache object to store results of function calls
    let call = 0; //counter for unique function calls
    return function(...args) {
        if(args.length === 0) { //if no arguments - return the number of unique calls
            return call;
        }
        const key = JSON.stringify(args); //converting arguments to a string, so it can be used as a key
        if(!(key in cache)) { //checks if the key already exists, if not then:
            cache[key] = fn(...args); //call the function and store the result in the cache
            call++; //increment counter for unique calls
        }
        return cache[key]; //return the cached result
    }
}

//Case 1:
const sum = (a, b) => a + b;
let mem = memoize(sum);
console.log(`Result for case 1: [${mem(2,2)}, ${mem(2,2)}, ${mem()}, ${mem(1,2)}, ${mem()}]`);

//Case 2:
const factorial = (n) => (n <= 1) ? 1 : (n * factorial(n - 1));
let mem2 = memoize(factorial);
console.log(`Result for case 2: [${mem2(2)}, ${mem2(3)}, ${mem2(2)}, ${mem2()}, ${mem2(3)}, ${mem2()}]`);

//Case 3:
const fib = (n) => (n <= 1) ? 1 : (fib(n - 1) + fib(n - 2));
let mem3 = memoize(fib);
console.log(`Result for case 3: [${mem3(5)}, ${mem3()}]`);