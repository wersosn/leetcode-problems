//Delete the Middle Node of a Linked List
//Solution: Two Pointer approach
//Time complexity: O(n)
//I used here the explanation of the problem from user GiteshSK_12 (https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/solutions/4705282/simple-beginner-friendly-dry-run-two-pointer-approach-time-o-n-space-o-1-gits)
function ListNode(val, next) {
    this.val = (val === undefined ? 0 : val)
    this.next = (next === undefined ? null : next)
}

var deleteMiddle = function (head) {
    let slow, fast; //slow - moves one item at a time, fast - moves two items at a time
    if (head === null) { //if current head is empty (list is empty) - return null
        return null;
    }
    let prev = new ListNode(0); //paceholder to simplify edge case handling
    prev.next = head; //next value after prev is set to be head, to store original value
    slow = prev; //slow pointer starts at prev
    fast = head; //fast pointer starts at head
    while (fast != null && fast.next != null) { //loop until fast is at the last node (slow will be just before the middle)
        slow = slow.next; //make one step
        fast = fast.next.next; //make two steps
    }
    slow.next = slow.next.next; //remove middle node, by adjusting the next pointer to skip over this node
    let result = prev.next; //return original head
    return result;
};

//Case 1:
head = [1,3,4,7,1,2,6];
deleteMiddle(head);

//Case 2:
head2 = [1,2,3,4];
deleteMiddle(head2);

//Case 3:
head3 = [2,1];
deleteMiddle(head3);