// Pattern: Remove Nth Node From End of List
// When to use: When you need to remove the nth node from the end of a singly-linked list
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        ListNode slow = dummy;
        ListNode fast = dummy;
        for(int i = 0; i < n; i++) {
            fast = fast.next;
        }
        
        while(fast.next != null) {
            slow = slow.next;
            fast = fast.next;
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
        var result1 = solution.RemoveNthFromEnd(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 2);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.RemoveNthFromEnd(new ListNode(1), 1);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.RemoveNthFromEnd(new ListNode(1, new ListNode(2)), 1);
        Console.WriteLine("Result for case 3: " + result3);
    }
}