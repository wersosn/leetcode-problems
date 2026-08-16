//Twenty-second problem from '30 days of JavaScript':
//Time complexity: 1st solution: O(1), 2nd: O(n)
//First solution - access the last element:
Array.prototype.last2 = function() {
    if(this.length === 0) { //if arrays is empty - return -1
        return -1;
    }
    return this[this.length-1]; //else - return last element
};

//Second solution - reverse the array:
Array.prototype.last = function() {
    if(this.length === 0) { //if arrays is empty - return -1
        return -1;
    }
    this.reverse(); //else - reverse the array
    return this[0]; //return first element
};

//Case 1:
let nums = [null, {}, 3];
console.log(`Result for case 1:\n 1st: ${nums.last2()}\n 2nd: ${nums.last()}`);

//Case 2:
let nums2 = [];
console.log(`Result for case 2:\n 1st: ${nums2.last2()}\n 2nd: ${nums2.last()}`);