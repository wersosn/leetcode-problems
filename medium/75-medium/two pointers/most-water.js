//Container With Most Water
//Solution: Two-Pointer approach
//Time coplexity: O(n)
var maxArea = function (height) {
    let water = 0, maxWater = 0;
    let i = 0, j = height.length - 1; //two pointers -> i = left, j = right
    while (i < j) { //loop as long as the left pointer is less than the right pointer
        let x = j - i; //calculate x-axis
        let y = Math.min(height[i], height[j]); //calculate y-axis
        water = x * y; //calculate the water capacity of the current container
        maxWater = Math.max(maxWater, water); //find the max amount of water a container can store
        //adjust the pointers:
        if (height[i] < height[j]) { //if left is smaller than right -> move i pointer to the right
            i++;
        }
        else { //if right is smaller than left -> move j pointer to the left
            j--;
        }
    }
    return maxWater;
};

//Case 1:
let height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
console.log(`Result for case 1: ${maxArea(height)}`);

//Case 2:
let height2 = [1, 1];
console.log(`Result for case 2: ${maxArea(height2)}`);