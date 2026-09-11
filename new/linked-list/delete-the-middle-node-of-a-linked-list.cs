// Pattern: Delete the Middle Node of a Linked List
// When to use: Deleting the middle node of a linked list.
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
    public ListNode DeleteMiddle(ListNode head) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        ListNode slow = dummy;
        ListNode fast = dummy.next;
        while(fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        slow.next = slow.next.next;
        return dummy.next;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.DeleteMiddle(new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(7, new ListNode(1, new ListNode(2, new ListNode(6))))))));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.DeleteMiddle(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))));
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.DeleteMiddle(new ListNode(2, new ListNode(1)));
        Console.WriteLine("Result for case 3: " + result3);
    }
}