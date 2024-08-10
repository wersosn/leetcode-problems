//Solution: go through lists and add values to get the result
//Time complexity: O(man(n,m)), where n is a length of l1 and m is a length of l2
function ListNode(val, next) {
    this.val = (val === undefined ? 0 : val)
    this.next = (next === undefined ? null : next)
}

function toArray(head) {
    const tab = [];
    let x = head;
    while (x !== head) {
        tab.push(x.val);
        x = x.next;
    }
    return tab;
}

function toList(tab) {
    const frag = document.createDocumentFragment();
    tab.forEach(element => (frag.appendChild(element)));
    return frag.childNodes;
}

var addTwoNumbers = function (l1, l2) {
    let sum = 0; 
    let currentNode = new ListNode(0); //store the starting point of the result list
    let result = currentNode; //store the reference to the head of the result list

    do {
        if (l1) {
            sum += l1.val;
            l1 = l1.next;
        }
        if (l2) {
            sum += l2.val;
            l2 = l2.next;
        }
        currentNode.next = new ListNode(sum % 10);
        currentNode = currentNode.next;
        if (sum > 9) {
            sum = 1;
        }
        else {
            sum = 0;
        }

    } while (l1 || l2); //loop through the lists until they are completely reviewed

    if (sum) {
        currentNode.next = new ListNode(sum);
    }

    return result.next;
};
