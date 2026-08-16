//Kids With the Greatest Number of Candies
//Solution: Two loops - one to find the child with the maximum number of basic candies and the other to find the children with the number of candies greater than the maximum number of basic candies
//Time complexity: O(n)
var kidsWithCandies = function (candies, extraCandies) {
    let result = []; //boolean array to store results
    let allCandies = []; //array to store all the candy each child has
    let max = 0; //maximum number of basic candies
    let flag; //boolean flag

    //First loop - find the maximum number of basic candies and create an array with all candies
    for (let i = 0; i < candies.length; i++) {
        if (candies[i] > max) {
            max = candies[i];
        }
        allCandies[i] = candies[i] + extraCandies;
    }

    //Second loop - find the children with the number of candies greater than the maximum number of basic candies
    for (let j = 0; j < allCandies.length; j++) {
        if (allCandies[j] >= max) {
            flag = true;
            result.push(flag);
        }
        else {
            flag = false;
            result.push(flag);
        }
    }
    return result;
};

//Case 1:
let candies = [2,3,5,1,3], extraCandies = 3;
console.log(`Result for case 1: [${kidsWithCandies(candies, extraCandies)}]`);

//Case 2:
let candies2 = [4,2,1,1,2], extraCandies2 = 1;
console.log(`Result for case 2: [${kidsWithCandies(candies2, extraCandies2)}]`);

//Case 3:
let candies3 = [12,1,12], extraCandies3 = 10;
console.log(`Result for case 3: [${kidsWithCandies(candies3, extraCandies3)}]`);