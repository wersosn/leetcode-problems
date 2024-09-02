//Longest Subarray of 1's After Deleting One Element
//Solution: Sliding window algorithm -  two pointers are used to indicate a window of the array
//Time-complexity: O(n)
var longestSubarray = function (nums) {
    let start = 0, end = 0, counter = 0, maxLength = 0;
    for (end = 0; end < nums.length; end++) { //iterate through the array using 'end' as the right pointer
        if (nums[end] === 0) { //if the current element is 0, increment the counter
            counter++;
        }
        //if the count of zeros exceeds 1, adjust the window by moving 'start' to the right
        if (counter > 1) {
            if (nums[start] === 0) { //if the element at 'start' is 0, decrement the counter
                counter--;
            }
            start++; //move pointer to the right to shrink the window
        }
        if (counter <= 1) { //if the count of zeros is <= 1, calculate the maximum length of the subarray with at most one zero
            maxLength = Math.max(maxLength, end - start);
        }
    }
    return maxLength;
};

//Case 1:
nums = [1,1,0,1];
console.log(`Result for case 1: ${longestSubarray(nums)}`);

//Case 2:
nums = [0,1,1,1,0,1,1,0,1];
console.log(`Result for case 2: ${longestSubarray(nums)}`);

//Case 3:
nums = [1,1,1];
console.log(`Result for case 3: ${longestSubarray(nums)}`);