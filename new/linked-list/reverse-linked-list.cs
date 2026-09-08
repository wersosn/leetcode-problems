// Pattern: Reverse Linked List
// When to use: Reversing a singly linked list, often used in problems involving linked list manipulation
// Complexity: O(n) time, O(1) space

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
    public ListNode ReverseList(ListNode head) {
        ListNode current = head;
        ListNode prev = null;
        ListNode next;
        while(current != null) {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.ReverseList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.ReverseList(new ListNode(1, new ListNode(2)));
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.ReverseList(null);
        Console.WriteLine("Result for case 3: " + result3);
    }
}