//Number of Recent Calls
//Solution: Track recent requests by maintaining a timestamp queue and remove those that are outside the 3000ms window, returning a count of valid requests
//Time-complexity: O(n)
//I used here the explanation of the problem from user deepeshovercoder (https://leetcode.com/problems/number-of-recent-calls/solutions/4644207/fully-explained)
var RecentCounter = function() {
    this.queue = []; //initialize an empty array to store timestamps
};

RecentCounter.prototype.ping = function(t) {
    let range = t - 3000; //calculate the lower bound of the interval [t-3000, t]
    this.queue.push(t); //add current timestamp
    while(this.queue[0] < range) { //remove timestamps older than 3000ms
        this.queue.shift(); //shift elements until timestamp at the front is within the 3000ms
    }
    let length = this.queue.length; //calculate the length of queue (number of recent requests)
    return length;
};

//Case 1:
var recentCounter = new RecentCounter();
console.log(recentCounter.ping(1)); //1
console.log(recentCounter.ping(100)); //2
console.log(recentCounter.ping(3001)); //3
console.log(recentCounter.ping(3002));  //3


