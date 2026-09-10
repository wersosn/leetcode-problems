// Pattern: Reorder List
// When to use: Reordering a linked list in a specific pattern (L0 → Ln → L1 → Ln-1 → L2 → Ln-2 → …)
// Complexity: O(n) time, O(1) space, where n is the length of the list

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public void ReorderList(ListNode head) {
        if(head == null || head.next == null) {
            return;
        }

        // 1. Find the middle of the linked list - linked list cycle detection technique
        ListNode slow = head;
        ListNode fast = head;
        ListNode middle = null;
        while(fast != null && fast.next != null) {
            middle = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        middle.next = null;

        // 2. Reverse the second half of the linked list - reverse linked list technique
        ListNode current = slow;
        ListNode prev = null;
        ListNode next;
        while(current != null) {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        // 3. Merge the two halves - similar to merge two sorted lists technique
        ListNode first = head;
        ListNode second = prev;
        ListNode nextFirst = null, nextSecond = null;
        while(second != null) {
            nextFirst = first.next;
            nextSecond = second.next;
            first.next = second;
            if (nextFirst == null) {
                break;
            }
            second.next = nextFirst; 
            first = nextFirst;
            second = nextSecond;
        }

        return;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.ReorderList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.ReorderList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))));
        Console.WriteLine("Result for case 2: " + result2);
    }
}