//Seventeenth problem from '30 days of JavaScript':
//Time complexity: O(n)
//To solve this problem, I used the explanation of the problem by user jwseph and akshaychavan7
var TimeLimitedCache = function () {
    cache = new Map(); //create map
};

TimeLimitedCache.prototype.set = function (key, value, duration) {
    let exists = cache.has(key); //assing a key to a variable
    if (exists) { //check if key already exists, if yes then:
        clearTimeout(cache.get(key).timer); //clear the timer
    } //else:
    let timer = setTimeout(() => cache.delete(key), duration); //set a new timer to remove the key after a specified duration
    cache.set(key, { value: value, timer: timer }); //change key
    return exists; //return true
};

TimeLimitedCache.prototype.get = function (key) {
    if (cache.has(key)) { //check if Map has this key, if yes then:
        let keyValue = cache.get(key).value; //assign associated value
        return keyValue; //return it
    }
    else {
        return -1; //return -1
    }
};

TimeLimitedCache.prototype.count = function () {
    let count = cache.size; //assign Map size to variable
    return count; //return the count value
};

//Case 1:
const timeLimitedCache = new TimeLimitedCache()
let a = timeLimitedCache.set(1, 42, 1000); // false
let b = timeLimitedCache.get(1); // 42
let c = timeLimitedCache.count(); // 1
console.log(`Result for case 1: [null, ${a}, ${b}, ${c}]`);
