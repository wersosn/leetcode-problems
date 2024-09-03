//Unique Number of Occurrences
//Solution: Count the occurrences of each unique element in the array, check if all counts are unique, and then return true if they are, otherwise false.
//Time-complexity: O(n)
var uniqueOccurrences = function (arr) {
    let result = []; //array to store the count of unique occurrences
    let counter = 0; //counter to track occurrences of each element

    for (let i = 0; i < arr.length; ) { //outer loop to iterate through the array
        for (let j = i; j < arr.length; ) { //inner loop to compare the current element with the rest of the array
            if (arr[i] === arr[j] && i !== j) { //if current element is the same in arr[i] and arr[j] AND index i != index j
                counter++; //increase counter
                arr.splice(j, 1); //remove the duplicate element from the array
            }
            else {
                j++; //else move to the next element if no duplicate is found
            }
        }
        result.push(counter); //push the count of occurrences for the current element to the result array
        counter = 0; //reset counter
        arr.splice(i, 1); //remove the current element from the array
    }
    result.sort(); //sort the result array

    for (let i = 0; i < result.length; i++) { //loop to check if there are any duplicate counts in the result array
        if (result[i] === result[i + 1]) { //if there is a duplicate - return false
            return false;
        }
    }
    return true; //else if all counts are unique - return true
};

//Case 1:
arr = [1,2,2,1,1,3];
console.log(`Result for case 1: ${uniqueOccurrences(arr)}`);

//Case 2:
arr = [1,2];
console.log(`Result for case 2: ${uniqueOccurrences(arr)}`);

//Case 3:
arr = [-3,0,1,-3,1,1,1,-3,10,0];
console.log(`Result for case 3: ${uniqueOccurrences(arr)}`);