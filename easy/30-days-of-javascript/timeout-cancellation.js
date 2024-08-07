//Fourteenth problem from '30 days of JavaScript':
//Time complexity: O(1)
var cancellable = function(fn, args, t) {
    const timer = setTimeout(function() { fn(...args) }, t); //set a timer so that the function will be executed after delay t
    return function() {
        clearTimeout(timer); //clear timeout
    };
};

//Case 1:
const result = [];
const fn = (x) => x * 5;
const args = [2], t = 20, cancelTimeMs = 50;
const start = performance.now();
const log = (...argsArr) => {
      const diff = Math.floor(performance.now() - start);
      result.push({"time": diff, "returned": fn(...argsArr)});
}
const cancel = cancellable(log, args, t);
const maxT = Math.max(t, cancelTimeMs);
setTimeout(cancel, cancelTimeMs);
setTimeout(() => {
      console.log(result);
}, maxT + 15);

//Case 2:
const result2 = [];
const fn2 = (x) => x ** 2;
const args2 = [2], t2 = 100, cancelTimeMs2 = 50;
const start2 = performance.now();
const log2 = (...argsArr) => {
      const diff = Math.floor(performance.now() - start);
      result.push({"time": diff, "returned": fn(...argsArr)});
}
const cancel2 = cancellable(log2, args2, t2);
const maxT2 = Math.max(t2, cancelTimeMs2);
setTimeout(cancel2, cancelTimeMs2);
setTimeout(() => {
      console.log(result2);
}, maxT2 + 15);
