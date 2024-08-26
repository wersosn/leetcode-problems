//Solution: Using array for storing seen numbers
//Time complexity: O(n^2)
var twoSum = function (nums, target) {
    const seen = [];
    for(let i = 0; i < nums.length; i++) { //loop through the nums array
        let n = nums[i]; //assign current number to n
        if(seen.includes(target - n)) { //check if there is the value that when added will create a target value 
            return [seen.indexOf(target - n), i]; //return result
        }
        seen.push(n); //add current number to array
    }
};

//Case 1:
const nums1 = [2, 7, 11, 15];
const target1 = 9;
const result1 = twoSum(nums1, target1);
console.log(`Result for case 1: [${result1}]`);

//Case 2:
const nums2 = [3, 2, 4];
const target2 = 6;
const result2 = twoSum(nums2, target2);
console.log(`Result for case 2: [${result2}]`);

//Case 3:
const nums3 = [3, 3];
const target3 = 6;
const result3 = twoSum(nums3, target3);
console.log(`Result for case 3: [${result3}]`);

//Case 4:
const nums4 = [4, 1, 2, 3, 5];
const target4 = 8;
const result4 = twoSum(nums4, target4);
console.log(`Result for case 4: [${result4}]`);