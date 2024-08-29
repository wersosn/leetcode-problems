//Solution: Calculate the sum of absolute differences between ASCII values of consecutive characters in a given string
//Time complexity: O(n)
var scoreOfString = function (s) {
    let sum = 0;
    let tmp = s.split("");
    for (let i = 0; i < tmp.length - 1; i++) {
        let x = tmp[i].charCodeAt(0);
        let y = tmp[i + 1].charCodeAt(0);
        sum += Math.abs(x - y);
    }
    return sum;
};

//Case 1:
s = "hello";
console.log(`Result for case 1: ${scoreOfString(s)}`);

//Case 2:
s = "zaz";
console.log(`Result for case 2: ${scoreOfString(s)}`);