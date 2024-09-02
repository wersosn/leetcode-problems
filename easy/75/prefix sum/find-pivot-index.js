//Find Pivot Index
//Solution: Calculate the grand total on the left and the grand total on the right
//Time-complexity: O(n)
var pivotIndex = function (nums) {
    let sumL = 0, sumR = 0, sum = 0;
    for (let i = 0; i < nums.length; i++) { //first - calculate sum of all elements in the array 'nums'
        sum += nums[i];
    }
    //second - iterate through each index to find the pivot index
    for (let i = 0; i < nums.length; i++) {
        //calculate the right sum for the current index
        sumR = sum - nums[i] - sumL; //sumR = total sum - current number - left sum
        if (sumR !== sumL) { //if sums are not equal - add the current number to the left sum
            sumL += nums[i];
        }
        else { //if sums are equal - return the current index as the pivot index
            return i;
        }
    }
    return -1; //if no pivot index is found, return -1
};

//Case 1:
nums = [1, 7, 3, 6, 5, 6];
console.log(`Result for case 1: ${pivotIndex(nums)}`);

//Case 2:
nums = [1, 2, 3];
console.log(`Result for case 2: ${pivotIndex(nums)}`);

//Case 3:
nums = [2, 1, -1];
console.log(`Result for case 3: ${pivotIndex(nums)}`);