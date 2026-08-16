//Eighteenth problem from '30 days of JavaScript':
//Time complexity: O(1)
var debounce = function(fn, t) {
    let timer;
    return function(...args) {
        clearTimeout(timer); //first - reset the timer, after every time function was called
        timer = setTimeout(() => fn(...args), t); //second - sets a new timer so the function cas be executed
    }
};

//Case 1:
let start = Date.now();
function log(...inputs) { 
  console.log(`["t": ${Date.now() - start}, inputs: [${inputs}] ]`);
}
const dlog = debounce(log, 50);
setTimeout(() => dlog(1), 50);
setTimeout(() => dlog(2), 75);
