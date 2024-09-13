//Keys and Rooms
//Solution: Check if you can visit all rooms, starting from room 0 and collecting keys to other rooms
//Time complexity: O(n + e), where n - number of rooms, e - number of keys
var canVisitAllRooms = function (rooms) {
    let visited = []; //array to keep track of visited rooms
    let queue = [0]; //queue, starts at room 0
    visited.push(0); //add room 0 to the visited rooms

    while (queue.length > 0) { //as long as there is a queue
        let room = queue.shift(); //take the current room from the queue
        let keys = rooms[room]; //get the keys for this room
        for (let k of keys) { //try to visit rooms using collected keys
            if (!visited.includes(k)) { //if the room hasn't been visited yet
                visited.push(k); //add it to the visited rooms
                queue.push(k); //add key found in this room to the queue
            }
        }
    }

    if (visited.length === rooms.length) { //if all rooms have been visited
        return true;
    }
    else {
        return false;
    }
};

//Case 1:
rooms = [[1], [2], [3], []];
console.log(`Result for case 1: ${canVisitAllRooms(rooms)}`);

//Case 2:
rooms = [[1, 3], [3, 0, 1], [2], [0]];
console.log(`Result for case 2: ${canVisitAllRooms(rooms)}`);