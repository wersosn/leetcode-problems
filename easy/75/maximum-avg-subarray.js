//Maximum Average Subarray I
//Solution: Find the maximum average of any k consecutive elements in an array by using a sliding window technique to efficiently calculate and compare sums.
//Time-complexity: O(n)
var findMaxAverage = function (nums, k) {
    let x = 0, y = k - 1, sum = 0, avg = 0;
    if (k === 1 && nums.length === 1) { //if k = 1 and array length = 1
        avg = nums[0] / 1; //the average is this one value divided by 1
        return avg;
    }
    //in other cases:
    for (let i = 0; i <= k - 1; i++) { //calculate the sum of the first 'k' elements
        sum += nums[i];
    }

    let max = sum; //create a max variable
    while (y !== nums.length - 1) { //slide the window across the array to find the maximum sum of any 'k' consecutive elements
        max = max - nums[x++]; //subtract the element leaving the window and increment 'x'
        max = max + nums[++y]; //add the new element entering the window and increment 'y'
        if (max > sum) { //if current max is sum is greater than the current sum
            sum = max; //update sum
        }
    }
    avg = sum / k; //calculate average value
    return avg;
};

//Case 1:
nums = [1,12,-5,-6,50,3], k = 4;
console.log(`Result for case 1: ${findMaxAverage(nums, k)}`);

//Case 2:
nums = [5], k = 1;
console.log(`Result for case 2: ${findMaxAverage(nums, k)}`);