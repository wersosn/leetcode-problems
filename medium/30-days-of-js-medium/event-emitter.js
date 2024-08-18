//Twenty-eight problem from '30 days of JavaScript':
//Time complexity: O(n) - for subscribe, O(m) - for emit
//I used here the explanation of this problem by user TheGElCOgecko
class EventEmitter {
    arr = []; //create an array for storing callbacks

    subscribe(eventName, callback) {
        if(!this.arr[eventName]) { //check if event exists, if not:
            this.arr[eventName] = []; //set it to an empty array
        }
        else {
            this.arr[eventName] = this.arr[eventName];
        }
        this.arr[eventName].push(callback); //push the callback to arr
        return {
            unsubscribe: () => {
                if(this.arr[eventName].length > 1) { //if lenght of arr is > 1
                    this.arr[eventName].shift(); //shift from arr[eventName]
                }
                else {
                    delete this.arr[eventName]; //delete arr[eventName]
                }
            }
        };
    }
    
    emit(eventName, args = []) {
        if(this.arr[eventName]) { //if event exists in the array
            let tmp = this.arr[eventName].map((callback) => callback(...args)); //return the result from calling all the callbacks of an event
            return tmp;
        }
        return []; //else if event doesn't exist - return an empty array
    }
}