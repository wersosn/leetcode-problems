//Twenty-ninth problem from '30 days of JavaScript':
//Time complexity: O(n)
var ArrayWrapper = function (nums) {
    this.nums = nums;
};

ArrayWrapper.prototype.valueOf = function () { //add all the elements
    let result = 0;
    for (let i = 0; i < this.nums.length; i++) {
        result += this.nums[i];
    }
    return result;
}

ArrayWrapper.prototype.toString = function () { //change integer array to a string
    let string = `[${this.nums.join(',')}]`;
    return string;
}

//Case 1:
const obj1 = new ArrayWrapper([1,2]);
const obj2 = new ArrayWrapper([3,4]);
const result = obj1 + obj2;
console.log(`Result for case 1: ${result}`);

//Case 2:
const obj = new ArrayWrapper([23,98,42,70]);
const result2 = String(obj);
console.log(`Result for case 2: ${result2}`);

//Case 3:
const obj3 = new ArrayWrapper([]);
const obj4 = new ArrayWrapper([]);
const result3 = obj3 + obj4;
console.log(`Result for case 3: ${result3}`);