//Removing Stars From a String
//Solution: Use a stack to store the characters. Pop one character off the stack at each star. Otherwise, we push the character onto the stack.
//Time-complexity: O(n)
var removeStars = function (s) {
    let arr = s.split(""); //conver string to the array
    let result = []; //initialize an empty array to store the result

    for (let i = 0; i < arr.length; i++) { //iterate through the array
        if (arr[i] === "*") { //if current character is a '*'
            result.pop(); //remove the last element from result
        }
        else {
            result.push(arr[i]); //add current element to result
        }
    }

    let string = result.join(""); //convert array back to string
    return string;
};

//Case 1:
s = "leet**cod*e";
console.log(`Result for case 1: "${removeStars(s)}"`);

//Case 2:
s = "erase*****";
console.log(`Result for case 2: "${removeStars(s)}"`);
