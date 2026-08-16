//Reverse Words in a String
//Solution: Convert string to array and reverse it
//Time complexity: O(n)
var reverseWords = function(s) {
    let reversed = s.trim().split(/\s+/); //convert string to array 
    //use trim() - to remove whitespace from both sides of a string 
    //use split(/\s+/) - to split a string into an array using the regular expression '\s+', which means one or more whitespaces
    reversed.reverse(); //reverse the array
    let result = reversed.join(' '); //convert it back to a string
    return result; //return reversed words in a string
};

//Case 1:
let s = "the sky is blue";
console.log(`Result for case 1: ${s} -> ${reverseWords(s)}`);

//Case 2:
let s2 = "  hello world  ";
console.log(`Result for case 2: ${s2} -> ${reverseWords(s2)}`);

//Case 3:
let s3 = "a good   example";
console.log(`Result for case 3: ${s3} -> ${reverseWords(s3)}`);