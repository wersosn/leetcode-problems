//Max Consecutive Ones III
//Solution: Sliding window algorithm -  two pointers are used to indicate a window of the array
//Time-complexity: O(n)
//I used here the explanation of the problem from user ankitk742 (https://leetcode.com/problems/max-consecutive-ones-iii/description/comments/2030040)
//and nylime (https://leetcode.com/problems/max-consecutive-ones-iii/description/comments/1695661)
var longestOnes = function (nums, k) {
    let start = 0, end = 0, counter = 0, maxLength = 0;
    for (end = 0; end < nums.length; end++) { //iterate through the array using 'end' as the right pointer
        if (nums[end] === 0) { //if the current element is 0, increment the counter
            counter++;
        }
        //if the count of zeros exceeds 'k', adjust the window by moving 'start' to the right
        if (counter > k) {
            if (nums[start] === 0) { //if the element at 'start' is 0, decrement the counter
                counter--;
            }
            start++; //move pointer to the right to shrink the window
        }
        maxLength = Math.max(maxLength, end - start + 1); //calculate the maximum length of the window
    }
    return maxLength;
};

//Case 1:
nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2;
console.log(`Result for case 1: ${longestOnes(nums, k)}`);

//Case 2:
nums = [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1], k = 3;
console.log(`Result for case 2: ${longestOnes(nums, k)}`);