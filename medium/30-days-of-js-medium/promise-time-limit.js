//Sixteenth problem from '30 days of JavaScript':
//Time complexity: O(1)
var timeLimit = function(fn, t) {
    return async function(...args) {
        let promise = new Promise((resolve, reject) => { //creating Promise to handle the async execution
            const timer = setTimeout(() => { clearTimeout(timer); reject("Time Limit Exceeded")}, t); //set a timer
            let x = fn(...args); //call the original function 
            x.then(
                function(result) { clearTimeout(timer); resolve(result); }, //if the function completes before the time limit, resolve the promise with the result.
                function(error) { clearTimeout(timer); reject(error); } //else if the function exceeds the time limit, reject the promise with the error
            );
        });
        return promise; //return our promise
    }
};

//Case 1:
let fn = async (n) => { 
    await new Promise(res => setTimeout(res, 100)); 
    return n * n; 
  }
let inputs = [5]
let t = 50
const limited = timeLimit(fn, t)
const run = async () => {
    const start = performance.now();
    let result;
    try {
        const res = await limited(...inputs);
        result = { "resolved": res, "time": Math.floor(performance.now() - start) };
    } catch (err) {
        result = { "rejected": err, "time": Math.floor(performance.now() - start) };
    }
    console.log(result);
};
run();
