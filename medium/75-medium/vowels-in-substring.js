//Maximum Number of Vowels in a Substring of Given Length
//Solution: Iterate through the array to find maximum number of vowels in any substring
//Time-complexity: O(n)
var maxVowels = function (s, k) {
    let arr = s.split("");
    let vowels = 'aeiou';
    let vow = 0; //vow - number of vowels in any substring
    let x = 0, max = 0; //x - starting index of the sliding window, max - maximum number of vowels in any substring
    for (let i = 0; i < arr.length; i++) {
        if (vowels.includes(arr[i])) { //if current element is a vowel - increment vow
            vow++;
        }
        if (i - x + 1 === k) { //if current index i - x + 1 is equal to k - check for the max value
            max = Math.max(vow, max); //update max with the highest number of vowels found
            if (vowels.includes(arr[x])) { //if the character at the start of the window is a vowel, decrement vow
                vow--;
            }
            x++; //move the window forward by incrementing the starting index
        }
    }
    return max;
};

//Case 1:
s = "abciiidef", k = 3;
console.log(`Result for case 1: ${maxVowels(s, k)}`);

//Case 2:
s = "aeiou", k = 2;
console.log(`Result for case 2: ${maxVowels(s, k)}`);

//Case 3:
s = "leetcode", k = 3;
console.log(`Result for case 3: ${maxVowels(s, k)}`);