// Pattern: Linked List Cycle
// When to use: Detecting cycles in a linked list
// Complexity: O(n) time, O(1) space, where n is the number of nodes in the list

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while(fast != null && fast.next != null) {
            slow = slow.next;
            ListNode n = fast.next;
            fast = n.next;
            if(slow == fast) {
                return true;
            }
        }
        return false;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.HasCycle(new ListNode(3, new ListNode(2, new ListNode(0, new ListNode(-4)))));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.HasCycle(new ListNode(1, new ListNode(2)));
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.HasCycle(new ListNode(1));
        Console.WriteLine("Result for case 3: " + result3);
    }
}