// Pattern: Swapping Nodes in a Linked List
// When to use: Swapping the values of two nodes in a linked list based on their positions (k-th node from the beginning and k-th node from the end).
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
    public ListNode SwapNodes(ListNode head, int k) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        ListNode slow = dummy;
        ListNode fast = dummy;
        for(int i = 0; i < k; i++) {
            fast = fast.next;
        }
        ListNode beginning = fast;

        while(fast.next != null) {
            slow = slow.next;
            fast = fast.next;
        }
        ListNode ending = slow.next;

        int tmp = beginning.val;
        beginning.val = ending.val;
        ending.val = tmp;
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
        var result1 = solution.SwapNodes(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 2);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.SwapNodes(new ListNode(7, new ListNode(9, new ListNode(6, new ListNode(6, new ListNode(7, new ListNode(8, new ListNode(3, new ListNode(0, new ListNode(9, new ListNode(5)))))))))), 5);
        Console.WriteLine("Result for case 2: " + result2);
    }
}