//Fifteenth problem from '30 days of JavaScript':
//Time complexity: O(1)
var cancellable = function(fn, args, t) {
    fn(...args); //execute the function for the first time 
    let interval = setInterval(function() { fn(...args) }, t); //set an interval to repeatedly execute the function every t milliseconds

    return function() { //return a function that can be called to stop the repeated execution
        clearInterval(interval); //clear the interval to stop the repeated execution of the function
    };
};

//Case 1:
const result = [];
const fn = (x) => x * 2;
const args = [4], t = 35, cancelTimeMs = 190;
const start = performance.now();
const log = (...argsArr) => {
        const diff = Math.floor(performance.now() - start);
        result.push({"time": diff, "returned": fn(...argsArr)});
    }
const cancel = cancellable(log, args, t);
setTimeout(cancel, cancelTimeMs);
setTimeout(() => {
        console.log(result); 
    }, cancelTimeMs + t + 15);
