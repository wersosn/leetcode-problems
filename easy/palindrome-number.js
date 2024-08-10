//Solution: using a loop to create reversed number
//Time complexity: O(logx)
var isPalindrome = function(x) {
    let reversed = 0; //reversed number
    let original = x; //stores original value
    while(original > 0) {
        reversed = reversed * 10 + (original%10); //add the last number of 'x' to variable 'reversed'
        original = Math.floor(original/10); //cut the last number from x
    }

    if(reversed === x) { //check if number is a palindrome, if yes then:
        return true;
    }
    else {
        return false;
    }
};

//Case 1:
let r = isPalindrome(121);
console.log(`Result for case 1: ${r}`);

//Case 2:
let r2 = isPalindrome(-121);
console.log(`Result for case 2: ${r2}`);

//Case 3:
let r3 = isPalindrome(10);
console.log(`Result for case 3: ${r3}`);