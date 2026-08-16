//Solution: Check if there is a target number in the array. If no - return the index where it would be if it were inserted in order.
//Time complexity: O(n)
var searchInsert = function (nums, target) {
    if (!nums.includes(target)) { //check if the target is not found in the array
        for (let i = 0; i < nums.length; i++) { //loop through the array to find the correct insertion index
            if (target < nums[i] && i === 0) { //if the target is smaller than the first element
                return 0; //return thefirst index (0)
            }
            else if (target > nums[i] && i === nums.length - 1) { //if the target is greater than the first element
                return i + 1; //return last index + 1 (i+1)
            }
            else if (target > nums[i - 1] && target < nums[i]) { //if the target is greater than the previous element and smaller than the current element
                return i; //return current index
            }
        }
    }
    else { //if target is found in the array:
        return nums.indexOf(target); //return the index
    }
};

//Case 1:
nums = [1, 3, 5, 6], target = 5;
console.log(`Result for case 1: ${searchInsert(nums, target)}`);

//Case 2:
nums = [1, 3, 5, 6], target = 2;
console.log(`Result for case 2: ${searchInsert(nums, target)}`);

//Case 3:
nums = [1, 3, 5, 6], target = 7;
console.log(`Result for case 3: ${searchInsert(nums, target)}`);