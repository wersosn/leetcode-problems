//Determine if Two Strings Are Close
//Solution: Check if two strings are "close strings" by ensuring they have the same length, the same set of unique characters, and matching frequency counts of these characters
//Time-complexity: O(n)
var closeStrings = function (word1, word2) {
    //initialize two arrays to count occurrences of each letter:
    const count1 = new Array(26).fill(0);
    const count2 = new Array(26).fill(0);
    if (word1.length !== word2.length) { //check if both words are of same length, if not - return false
        return false;
    }

    for (let char of word1) { //count the frequency of each character in word1
        count1[char.charCodeAt(0) - 97]++;
    }
    for (let char of word2) { //count the frequency of each character in word2
        count2[char.charCodeAt(0) - 97]++;
    }

    for (let i = 0; i < 26; i++) { //check if both words have the same unique characters
        if ((count1[i] === 0) !== (count2[i] === 0)) { //if characters are different - return false
            return false;
        }
    }
    //sort both arrays:
    count1.sort((a, b) => a - b);
    count2.sort((a, b) => a - b);
    for (let i = 0; i < 26; i++) { //check if the sorted frequency counts match
        if (count1[i] !== count2[i]) { //if the frequency counts don't match - return false
            return false;
        }
    }
    return true; //the words are close strings - return true
};

//Case 1:
word1 = "abc", word2 = "bca";
console.log(`Result for case 1: ${closeStrings(word1, word2)}`);

//Case 2:
word1 = "a", word2 = "aa";
console.log(`Result for case 2: ${closeStrings(word1, word2)}`);

//Case 3:
word1 = "cabbba", word2 = "abbccc";
console.log(`Result for case 3: ${closeStrings(word1, word2)}`);
