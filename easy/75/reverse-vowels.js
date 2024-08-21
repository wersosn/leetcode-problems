//Reverse Vowels of a String
//Solution: I used here two-pointer approach by user dev_arsh
//Time complexity: O(n)
var reverseVowels = function (s) {
    let reverse = s.split(''); //create an array from string
    let vowels = 'AEIOUaeiou'; //set of possible vowels
    let left = 0, right = s.length - 1; //two pointers, the left pointer represents the beginning of the string, and the right pointer represents its end

    while (left < right) { //iterate as long as left is less than right
        while (left < right && !vowels.includes(reverse[left])) { //while left is less than right and current character at 'left' isn't a vowel
            left++; //move the left pointer
        }
        while (left < right && !vowels.includes(reverse[right])) { //while left is less than right and current character at 'right' isn't a vowel
            right--; //move the right pointer
        }
        [reverse[left], reverse[right]] = [reverse[right], reverse[left]]; //swap the vowels around
        //continue the process, by incrementing left pointer and decrementing right pointer:
        left++;
        right--;
    }

    return reverse.join(''); //conver the array back to string
};

//Case 1:
let s = "hello";
console.log(`Result for case 1: ${s} -> ${reverseVowels(s)}`);

//Case 2:
let s2 = "leetcode";
console.log(`Result for case 2: ${s2} -> ${reverseVowels(s2)}`);