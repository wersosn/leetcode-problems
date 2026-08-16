//Decode String
//Solution: Use a stack to decode a string with nested patterns, handling repeated substrings by keeping track of characters in parentheses and their corresponding multipliers
//Time-complexity: O(n)
//I used here the explanation of the problem from user poppinlp (https://leetcode.com/problems/decode-string/solutions/384193/javascript-easy-to-understand-using-stack-44ms)
var decodeString = function (s) {
    let result = []; //initialize an empty stack to store characters and decoded parts
    for (let i of s) { //loop through each character in the input string `s`
        if (i !== "]") { //if current character is not a closing bracket
            result.push(i); //push it to the stack
            continue; //and move to the next character
        }
        //else - start building the substring inside the brackets
        let string = "";
        let curr = result.pop(); //pop the top element from the stack
        while (curr !== "[") { //keep popping from the stack until we encounter an opening bracket
            string = curr + string; //build the substring
            curr = result.pop(); //continue popping from the stack
        }
        //next - handle the multiplier
        let multi = "";
        curr = result.pop(); //pop the next element, which should be part of the multiplier
        while (!Number.isNaN(Number(curr))) { //build the multiplier by popping digits
            multi = curr + multi; //build the multiplier
            curr = result.pop(); //continue popping if there are more digits
        }
        result.push(curr); //add back the character after the multiplier
        result.push(string.repeat(Number(multi))); //repeat the substring `multi` times and push it back to the stack
    }
    let decode = result.join(""); //convert to string
    return decode;
};

//Case 1:
s = "3[a]2[bc]";
console.log(`Result for case 1: ${decodeString(s)}`);

//Case 2:
s = "3[a2[c]]";
console.log(`Result for case 2: ${decodeString(s)}`);

//Case 3:
s = "2[abc]3[cd]ef";
console.log(`Result for case 3: ${decodeString(s)}`);