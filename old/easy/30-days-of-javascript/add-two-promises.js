//Twelfth problem from '30 days of JavaScript':
//Time complexity: O(1)
var addTwoPromises = async function(promise1, promise2) {
    let a = await promise1;
    let b = await promise2;
    return a + b;
};

//Case 1:
addTwoPromises(Promise.resolve(2), Promise.resolve(5)).then(console.log);

//Case 2:
addTwoPromises(Promise.resolve(10), Promise.resolve(-12)).then(console.log);