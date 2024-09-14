//Solution: Compare each subsequent string with the prefix and reduce it
//Time complexity: O(s), s - sum of all characters
var longestCommonPrefix = function (strs) {
    let prefix = strs[0]; //assume the first string is prefix
    if (strs === null || strs.length === 0) { //if array is empty -> return ""
        return "";
    }
    for (let i = 0; i < strs.length; i++) { //loop through strs array
        while (strs[i].indexOf(prefix) !== 0) { //loop until the prefix we are currently examining is at the beginning of the string
            prefix = prefix.slice(0, prefix.length - 1); //shorten prefix by 1 character
            if (prefix === "") { //if prefix is empty - return ""
                return "";
            }
        }
    }
    return prefix; //if there is the same common prefix - return it
};

//Case 1:
strs = ["flower", "flow", "flight"];
console.log(`Result for case 1: "${longestCommonPrefix(strs)}"`);

//Case 2:
strs = ["dog", "racecar", "car"];
console.log(`Result for case 2: "${longestCommonPrefix(strs)}"`);

