//Solution: using a loop to create reversed number
//Time complexity: O(d), where d is the number of digits in number x
function isPalindrome2(x: number): boolean {
    let reversed: number = 0; //reversed number
    let original: number = x; //stores original value
    while (original > 0) {
        reversed = reversed * 10 + (original % 10); //add the last number of 'x' to variable 'reversed'
        original = Math.floor(original / 10); //cut the last number from x
    }

    if (reversed === x) { //check if number is a palindrome, if yes then:
        return true;
    }
    else {
        return false;
    }
};