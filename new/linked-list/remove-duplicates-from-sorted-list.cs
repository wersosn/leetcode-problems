// Pattern: Two-pointer technique
// When to use: When you have a sorted linked list and want to remove duplicate nodes
// Complexity: O(n) time, O(1) space, where n is the number of nodes in the list

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
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null) {
            return head;
        }
        
        ListNode dup = head;

        while(dup != null && dup.next != null) {
            if(dup.val == dup.next.val) {
                dup.next = dup.next.next;
            }
            else {
                dup = dup.next;
            }
        }
        return head;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.DeleteDuplicates(new ListNode(1, new ListNode(1, new ListNode(2))));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.DeleteDuplicates(new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3))))));
        Console.WriteLine("Result for case 2: " + result2);
    }
}