//Odd Even Linked List
//Solution: Transform the given singly linked list so that all nodes in odd positions are placed before all nodes in even positions, preserving the original order of both odd and even nodes
//Time complexity: O(n)
//I used here the explanation of the problem from user GiteshSK_12 (https://leetcode.com/problems/odd-even-linked-list/solutions/4761304/simple-beginner-friendly-dry-run-two-approach-full-explanation-time-o-n-space-o-1-gits)
function ListNode(val, next) {
    this.val = (val === undefined ? 0 : val)
    this.next = (next === undefined ? null : next)
}

var oddEvenList = function (head) {
    if (head === null || head.next === null) {
        return head;
    }
    let odd = head; //the odd element is the one that is head
    let even = head.next; //the even element is the one that comes next after head
    let ehead = even; //store the head og the even-indexed sublist

    while (even !== null && even.next !== null) { //loop until there are node to process
        odd.next = odd.next.next; //move to another odd element
        even.next = even.next.next; //move to another even element
        odd = odd.next; //current odd element is advanced to its next respective node
        even = even.next; //current even element is advanced to its next respective node
    }
    odd.next = ehead; //the last node in odd-indexed sublist is linked to the head of even-indexed sublist -> merge 2 sublists
    return head; //return reordered list
};

//Case 1:
head = [1,2,3,4,5];
oddEvenList(head);

//Case 2:
head2 = [2,1,3,5,6,4,7];
oddEvenList(head2);
