//Container Max Number of K-Sum Pairs
//Solution: Two-Pointer approach
//Time coplexity: O(nlogn)
var maxOperations = function (nums, k) {
    let counter = 0;
    let i = 0, j = nums.length - 1; //two pointers -> i = left, j = right
    nums.sort((a, b) => a - b); //sort the array
    while (i < j) { //loop as long as the left pointer is less than the right pointer
        let sum = nums[i] + nums[j]; //count the sum
        if (sum === k) { //if sum is equal to k -> increase counter and move pointers
            counter++;
            i++;
            j--;
        }
        else if (sum < k) { //else if sum is < k -> move the left pointer to the right
            i++;
        }
        else { //else if sum is > k -> move the right pointer to the left
            j--;
        }
    }
    return counter;
};

//Case 1:
let nums = [1, 2, 3, 4], k = 5;
console.log(`Result for case 1: ${maxOperations(nums, k)}`);

//Case 2:
let nums2 = [3, 1, 3, 4, 3], k2 = 6;
console.log(`Result for case 2: ${maxOperations(nums2, k2)}`);