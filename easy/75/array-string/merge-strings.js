//Merge Strings Alternately
//Solution: loop through each word and add one letter at a time
//Time-complexity: O(n)
var mergeAlternately = function (word1, word2) {
    let merged = ""; //new merged string
    const length = Math.max(word1.length, word2.length); //maximum length of the two words
    for (let i = 0; i < length; i++) {
        if(i < word1.length) { //if the current index is within the bounds of word1, add the character
            merged += word1[i];
        }
        if(i < word2.length) { //if the current index is within the bounds of word2, add the character
            merged += word2[i];
        }
    }
    return merged;
};

//Case 1:
let word1 = "abc", word2 = "pqr";
console.log(`Result for case 1: ${mergeAlternately(word1, word2)}`);

//Case 2:
let word3 = "ab", word4 = "pqrs";
console.log(`Result for case 2: ${mergeAlternately(word3, word4)}`);

//Case 3:
let word5 = "abcd", word6 = "pq";
console.log(`Result for case 3: ${mergeAlternately(word5, word6)}`);