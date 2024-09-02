//Can Place Flowers
//Solution: Go through an array of flowerbeds and check if you can place flowers without violating the no-adjacent-flowers rule
//Time complexity: O(n)
var canPlaceFlowers = function (flowerbed, n) {
    let count = 0; //counter
    if (n === 0) { //check if n is 0, so there are no flower that can be planted
        return true;
    }
    for (let i = 0; i < flowerbed.length; i++) {
        if (flowerbed[i] === 0 && flowerbed.length > 1) { //check if current place is empty and flowerbed length is > 1
            let emptyL = (i === 0) || (flowerbed[i - 1] === 0); //check if left plot is empty
            let emptyR = (i === flowerbed.length - 1) || (flowerbed[i + 1] === 0); //check if right plot is empty
            if (emptyL && emptyR) { //if both plots are empty - you can place flower here
                flowerbed[i] = 1; //now there is a flower in current place
                count++; //increment counter
            }
        }
        else if (flowerbed[i] === 0 && flowerbed.length === 1) { //check if current place is empty and flowerbed length is 1
            flowerbed[i] = 1; //now there is a flower in current place
            count++; //increment counter
        }

        if (count >= n) { //when counter is greater than or equal to n return true
            return true;
        }
    }
    return false; //else return false
};

//Case 1:
let flowerbed = [1,0,0,0,1], n = 1;
console.log(`Result for case 1: ${canPlaceFlowers(flowerbed, n)}`);

//Case 2:
let flowerbed2 = [1,0,0,0,1], n2 = 2;
console.log(`Result for case 2: ${canPlaceFlowers(flowerbed2, n2)}`);