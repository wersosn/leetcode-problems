//Maximum Twin Sum of a Linked List
//Solution: Convert LinkedList to Array and sum twin nodes
//Time complexity: O(n)
function ListNode(val, next) {
    this.val = (val === undefined ? 0 : val)
    this.next = (next === undefined ? null : next)
}

var pairSum = function (head) {
    let sum = 0, maxSum = 0;
    let arr = []; //initialize an array to hold values from the linked list
    let start = head; //start from the head of the linked list

    if (head === null) { ///if current head is empty (list is empty) - return null
        return null;
    }

    while (start !== null) {
        arr.push(start.val); //add the value of the current node to the array
        start = start.next; //move to next node
    }

    let i = 0, j = arr.length - 1; //i - pointer to the beginning of the array, j - pointer to the end of the array
    while (i < j) { //continue until the two pointers meet or cross
        sum = arr[i] + arr[j]; //calculate the sum
        if (sum > maxSum) { //check if current sum is greater than maxSum, if so:
            maxSum = sum; //update maxSum
        }
        //move to the next pair
        i++;
        j--;
    }

    return maxSum;
};

//Case 1:
head = [5,4,2,1];
pairSum(head); //6

//Case 2:
head2 = [4,2,2,3];
pairSum(head2); //7

//Case 3:
head3 = [1,100000];
pairSum(head3); //100001