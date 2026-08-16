//Solution: Use map to store pairs (symbol, value) and change the six instances where subtraction is used.
//Time complexity: O(n)
var romanToInt = function(s) {
    let sum = 0;
    let map = new Map();

    //Add values to the map:
    map.set('I', 1);
    map.set('V', 5);
    map.set('X', 10);
    map.set('L', 50);
    map.set('C', 100);
    map.set('D', 500);
    map.set('M', 1000);
    
    //Replace special cases:
    s = s.replace("IV", "IIII");
    s = s.replace("IX", "VIIII");
    s = s.replace("XL", "XXXX");
    s = s.replace("XC", "LXXXX");
    s = s.replace("CD", "CCCC");
    s = s.replace("CM", "DCCCC");

    //Calculate the sum:
    for(let i=0; i<s.length; i++) {
        sum += map.get(s[i]);
    }
    return sum;
};

//Case 1:
s = "III";
console.log(`Result for case 1: ${romanToInt(s)}`);

//Case 2:
s = "LVIII";
console.log(`Result for case 2: ${romanToInt(s)}`);

//Case 3:
s = "MCMXCIV";
console.log(`Result for case 3: ${romanToInt(s)}`);