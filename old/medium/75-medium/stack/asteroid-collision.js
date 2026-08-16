//Asteroid Collision
//Solution: Use a stack-based approach to ensure collisions are processed correctly and in the order they occur
//Time-complexity: O(n)
//I used here the explanation of the problem from user niits (https://leetcode.com/problems/asteroid-collision/solutions/5142202/video-simple-solution)
var asteroidCollision = function (asteroids) {
    let result = [];
    for (let i = 0; i < asteroids.length; i++) { //iterate through each asteroid in the array
        const last = result[result.length - 1]; //get the last asteroid in the result array
        if (asteroids[i] + asteroids[i + 1] === 0 && asteroids.length === 2) { //if the current asteroid and the next asteroid cancel each other out and only two asteroids are left, return an empty array
            return [];
        }

        if (asteroids[i] > 0 || last < 0 || !result.length) { //1. current asteroid is moving right OR the last asteroid in the result is moving left OR result is empty
            result.push(asteroids[i]); //add current element to the result array
        }
        else if (-(asteroids[i]) === last) { //2. current asteroid and the last asteroid are of the same magnitude but opposite directions (they collide)
            result.pop(); //remove the last element from the result array
        }
        else if (-(asteroids[i]) > last) { //3. current asteroid is larger than the last asteroid (the current asteroid destroys the last one)
            result.pop(); //remove the last element from the result array
            i--; //re-evaluate the new last asteroid
        }
    }
    return result;
};

//Case 1:
asteroids = [5, 10, -5];
console.log(`Result for case 1: [${asteroidCollision(asteroids)}]`);

//Case 2:
asteroids = [8, -8];
console.log(`Result for case 2: [${asteroidCollision(asteroids)}]`);

//Case 3:
asteroids = [10, 2, -5];
console.log(`Result for case 3: [${asteroidCollision(asteroids)}]`);