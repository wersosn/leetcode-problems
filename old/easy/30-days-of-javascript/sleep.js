//Thirteenth problem from '30 days of JavaScript':
//Time complexity: O(1)
async function sleep(millis) {
    let promise = new Promise((resolve, reject) => { //creating promise object that represents the completion or failure of an asynchronous operation and its result
        setTimeout(resolve, millis); //when the counter reaches zero (after the specified millis time), it calls the resolve function
    });
    return promise; //return promise object
}

//Case 1:
let t = Date.now();
sleep(100).then(() => console.log(Date.now() - t));

//Case 2:
let t2 = Date.now();
sleep(200).then(() => console.log(Date.now() - t2));

//Additional notes for myself: 
/* resolve - this is a function that is called when a promise IS fulfilled (completes successfully). 
   reject - this is a function that is called when a promise IS NOT fulfilled (ends in failure).*/