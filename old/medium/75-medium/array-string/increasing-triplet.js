//Increasing Triplet Subsequence
//Solution: Find 3 smallest values
//Time complexity: O(n)
var increasingTriplet = function (nums) {
    let min = Math.pow(2, 31) - 1, min2 = Math.pow(2, 31) - 1; //track the smallest and second smallest values
    for (let min3 of nums) {
        if (min3 < min) { //if the current number is smaller than smallest value -> update smallest value
            min = min3;
        }
        else if (min3 < min2 && min3 > min) { //if the current number is smaller than second smallest value and greater than smallest value -> update second smallest value
            min2 = min3;
        }
        else if (min3 > min2 && min3 > min) { //if the current number is greater than other smallest values -> return true
            return true;
        }
    }
    return false; //else return false (no increasing triplet subsequence was found)
};

//Case 1:
let nums = [1, 2, 3, 4, 5];
console.log(`Result for case 1: ${increasingTriplet(nums)}`);

//Case 2:
let nums2 = [5, 4, 3, 2, 1];
console.log(`Result for case 2: ${increasingTriplet(nums2)}`);

//Case 3:
let nums3 = [2, 1, 5, 0, 4, 6];
console.log(`Result for case 3: ${increasingTriplet(nums3)}`);