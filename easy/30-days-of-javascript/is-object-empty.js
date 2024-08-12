//Twentieth problem from '30 days of JavaScript':
//Time complexity: O(n) for both functions
//First solution - create an array from obj
var isEmpty = function(obj) {
    const arr = Object.values(obj);
    if(arr.length === 0) {
        return true;
    }
    else {
        return false;
    }
};

//Second solution - create a string from obj:
var isEmpty2 = function(obj) {
    const string = JSON.stringify(obj);
    if(string.length <= 2) {
        return true;
    }
    else {
        return false;
    }
};

//Case 1:
let obj = {"x": 5, "y": 42};
console.log(`Results for case 1:\n 1st ${isEmpty(obj)}\n 2nd ${isEmpty2(obj)}`);

//Case 2:
let obj2 = {};
console.log(`Results for case 2:\n 1st ${isEmpty(obj2)}\n 2nd ${isEmpty2(obj2)}`);

//Case 3:
let obj3 = [null, false, 0];
console.log(`Results for case 3:\n 1st ${isEmpty(obj3)}\n 2nd ${isEmpty2(obj3)}`);