//Move Zeroes
//Solution: Two pointer approach
//Time complexity: O(n)
var moveZeroes = function (nums) {
    let nonZero = 0; //this is a pointer that keeps track of where the next non-zero value in the array should be inserted
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] !== 0) { //if current number is not 0 
            nums[nonZero++] = nums[i]; //add it just in front of last non 0 element we found

        }
    }
    for (let i = nonZero; i < nums.length; i++) { //fill the remaining array with 0's
        nums[i] = 0;
    }
};

//Case 1:
let nums = [0,1,0,3,12];
let tmp = [0,1,0,3,12];
moveZeroes(nums);
console.log(`Result for case 1: [${tmp}] -> [${nums}]`);

//Case 2:
let nums2 = [0];
let tmp2 = [0];
moveZeroes(nums2);
console.log(`Result for case 2: [${tmp2}] -> [${nums2}]`);
