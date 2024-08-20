//Greatest Common Divisor of Strings
//Solution: Euclidean algorithm
//Time complexity: O(m+n)
var gcdOfStrings = function (str1, str2) {
    let divisor = ""; //empty string to store the greatest common divisor
    if (str1 + str2 !== str2 + str1) { //check if concatenating str1 + str2 is not equal to str2 + str1
        return divisor; //no common divisor exists
    }

    //get length of both strings and assign them to variables, for convenience 
    let a = str1.length;
    let b = str2.length;

    let gcd = function(a,b) { //function to calculate the greatest common divisor of two numbers using the Euclidean algorithm
        if(!b) { //if b is 0
            return a; //return length of str1 as the GCD
        }
        else {
            return gcd(b, a%b); //recursively call the gcd function with parameters (b, a % b) to calculate the GCD
        }
    }

    let gcdLength = gcd(a,b); //calculate the GCD of the lengths of str1 and str2
    divisor = str1.substring(0, gcdLength); //extract the substring from the start of str1 with a length equal to the GCD
    return divisor; //return the result - GCD string
};

//Case 1:
let str1 = "ABCABC", str2 = "ABC";
console.log(`Result for case 1: "${gcdOfStrings(str1, str2)}"`);

//Case 2:
let str3 = "ABABAB", str4 = "ABAB";
console.log(`Result for case 2: "${gcdOfStrings(str3, str4)}"`);

//Case 3:
let str5 = "LEET", str6 = "CODE";
console.log(`Result for case 3: "${gcdOfStrings(str5, str6)}"`);