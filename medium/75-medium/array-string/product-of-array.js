//Product of Array Except Self
//Solution: Calculate products before and after a given index
//Time complexity: O(n)
var productExceptSelf = function (nums) {
    let answer = []; //array to store the result
    //initialize two arrays of length 'nums.length' filled with '1'
    let left = new Array(nums.length).fill(1);
    let right = new Array(nums.length).fill(1);
    //1. calculate the product of all elements to the left 
    for (let i = 1; i < nums.length; i++) {
        left[i] = left[i - 1] * nums[i - 1]; //left[i] - all elements to the left of index 'i'
    }
    //2. calculate the product of all elements to the right
    for (let i = nums.length - 2; i >= 0; i--) {
        right[i] = right[i + 1] * nums[i + 1]; //right[i] - all elements to the right of index 'i'
    }
    //3. multiply these two products to get the answer
    for (let i = 0; i < nums.length; i++) {
        answer[i] = left[i] * right[i];
    }
    return answer;
};

//Case 1:
let nums = [1, 2, 3, 4];
console.log(`Result for case 1: [${nums}] -> [${productExceptSelf(nums)}]`);

//Case 2:
let nums2 = [-1, 1, 0, -3, 3];
console.log(`Result for case 2: [${nums2}] -> [${productExceptSelf(nums2)}]`);