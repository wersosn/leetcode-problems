//String Compression
//Solution: Two pointers to iterate through the input array
//Time complexity: O(n)
//I used here solution by user EmraanHash (https://leetcode.com/problems/string-compression/solutions/3246103/very-easy-100-easiest-logic-ever-fully-explained-step-by-step-c-javascript-java)
var compress = function(chars) {
    let length = 0;
    let i = 0;
    while(i < chars.length) { //loop through the array until the end
        let counter = 0;
        let x = chars[i]; //store the current character
        while(i < chars.length && chars[i] === x) { //count how many times the current character appears consecutively
            i++; //move to the next character
            counter++; //increase counter
        }
        chars[length++] = x; //assign character x to the current position (to compresse array)
        if(counter > 1) {
            for(let num of counter.toString()) { //convert counter to a string
                chars[length++] = num; //write each digit of the counter as a separate character in the array
            }
        }
    }
    return length; //return the new length of compressed array
};

//Case 1:
let chars = ["a","a","b","b","c","c","c"];
console.log(`Result for case 1: ${compress(chars)}`);

//Case 2:
let chars2 = ["a"];
console.log(`Result for case 2: ${compress(chars2)}`);

//Case 3:
let chars3 = ["a","b","b","b","b","b","b","b","b","b","b","b","b"];
console.log(`Result for case 3: ${compress(chars3)}`);