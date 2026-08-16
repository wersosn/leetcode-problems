//Is Subsequence
//Solution: Two-Pointer Subsequence Check
//Time coplexity: O(n)
var isSubsequence = function (s, t) {
    //change strings to arrays
    let x = s.split("");
    let y = t.split("");
    let tmp = 0, counter = 0;
    for (let i = 0; i < y.length; i++) { //iterate through each character in array 'y'
        if (x[tmp] === y[i]) { //check if the current character in 'y' matches the current character in 'x'
            counter++; //increase counter
            tmp++; //move to the next character in array 'x'
        }
    }
    //if the number of matches equals the length of 'x', then 's' is a subsequence of 't'
    if(counter === x.length) {
        return true;
    }
    else {
        return false;
    }
};

//Case 1:
let s = "abc", t = "ahbgdc";
console.log(`Result for case 1: ${isSubsequence(s, t)}`);

//Case 2:
let s2 = "axc", t2 = "ahbgdc";
console.log(`Result for case 2: ${isSubsequence(s2, t2)}`);