//Find the Highest Altitude
//Solution: Calculate sum and find highest altitude
//Time-complexity: O(n)
var largestAltitude = function (gain) {
    let sum = 0, max = 0;
    for (let i = 0; i < gain.length; i++) { //iterate through the array gain
        sum += gain[i]; //calculate sum
        if (sum > max) { //if current sum is grater than max, update max
            max = sum;
        }
    }
    return max;
};

//Case 1:
gain = [-5,1,5,0,-7];
console.log(`Result for case 1: ${largestAltitude(gain)}`);

//Case 2:
gain = [-4,-3,-2,-1,4,3,2];
console.log(`Result for case 2: ${largestAltitude(gain)}`);
