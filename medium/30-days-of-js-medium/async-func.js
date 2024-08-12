//Nineteenth problem from '30 days of JavaScript' - Execute Asynchronous Functions in Parallel:
//Time complexity: O(n)
var promiseAll = function(functions) {
    let promise = new Promise((resolve, reject) => {
        let l = functions.length; 
        if(l === 0) { //check if the input array is empty, if so:
            resolve([]); //immediately resolve
            return;
        }

        let arr = []; //initialize an array that will store resolved values of promises
        arr.fill(null); //fill all elements with null value
        let count = 0; //track the number of promises that have been resolved
        functions.forEach(async (x, idx) => {
            x().then(
                function(result) { //if all the promises returned from functions were resolved successfully - resolve the array of all resolved promises
                    arr[idx] = result; //add the value to the array
                    count++;
                    if(count === l) { //check if count is the same as length of functions
                        resolve(arr);
                    } 
                },
                function(error) { //if they were rejected - reject the promise with the reason of the first rejection
                    reject(error);
                }
            )
        });
    });
    return promise; //return new promise
};

//Case 1:
const promise = promiseAll([() => new Promise(res => res(42))]);
promise.then(console.log); //[42]

//Case 2:
const f1 = promiseAll([() => new Promise(resolve => setTimeout(() => resolve(5), 200))]);
f1.then(console.log); //[5]

//Case 3:
const f2 = promiseAll([() => new Promise(resolve => setTimeout(() => resolve(4), 50)), () => new Promise(resolve => setTimeout(() => resolve(10), 150)), () => new Promise(resolve => setTimeout(() => resolve(16), 100))]);
f2.then(console.log); //[4,10,16]
