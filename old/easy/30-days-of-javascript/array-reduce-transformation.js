//Seventh problem from '30 days of JavaScript':
//Time complexity: O(n)
var reduce = function (nums, fn, init) {
    let val = init;
    if (nums.length === 0) {
        return init;
    }
    else {
        for (let i = 0; i < nums.length; i++) {
            val = fn(val, nums[i]);
        }
        return val;
    }
};

//Case 1:
let nums = [1,2,3,4];
let fn = function sum(accum, curr) { return accum + curr; };
let init = 0;
let result = reduce(nums, fn, init);
console.log(`Result for case 1: ${result}`);

//Case 2:
let nums2 = [1,2,3,4];
let fn2 = function sum(accum, curr) { return accum + curr * curr; }
let init2 = 100;
let result2 = reduce(nums2, fn2, init2);
console.log(`Result for case 2: ${result2}`);

//Case 3:
let nums3 = [];
let fn3 = function sum(accum, curr) { return 0; };
let init3 = 25;
let result3 = reduce(nums3, fn3, init3);
console.log(`Result for case 3: ${result3}`);