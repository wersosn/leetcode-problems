//Reverse Linked List
//Solution: Change LinkedList to array, reverse it and change it back to LinkedList
//Time complexity: O(n)
function ListNode(val, next) {
    this.val = (val === undefined ? 0 : val)
    this.next = (next === undefined ? null : next)
}

var reverseList = function(head) {
    if(head === null) { //if the list is empty - return null
        return null;
    }
    let arr = []; //initialize an array to store the values from the list
    let current = head; //set the pointer to the start of the list

    while(current !== null) { //loop until the end
        arr.push(current.val); //add the value of the current node to the array
        current = current.next; //move to next node
    }
    arr.reverse(); //reverse array

    let h = new ListNode(arr[0]); //create a new reversed list and set head to the first element of the array
    let cur = h; //set the pointer to the start of the list
    for(let i=1; i<arr.length; i++) {
        cur.next = new ListNode(arr[i]); //add the current array element to the new list
        cur = cur.next; //move to next node
    }

    return h; //return reversed list
};

//Case 1:
head = [1,2,3,4,5];
reverseList(head);

//Case 2:
head2 = [1,2];
reverseList(head2);

//Case 3:
head3 = [];
reverseList(head3);