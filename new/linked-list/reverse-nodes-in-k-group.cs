// Pattern: Reverse Nodes in k-Group
// When to use: Reversing every k nodes in a linked list.
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
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        ListNode prevGroup = dummy;

        while(true) {
            ListNode kthElement = prevGroup;
            for(int i = 0; i < k; i++) {
                kthElement = kthElement.next;
                if(kthElement == null) {
                    return dummy.next;
                }
            }

            ListNode nextGroup = kthElement.next;
            ListNode groupStart = prevGroup.next;

            ListNode current = groupStart;
            ListNode prev = nextGroup;
            ListNode next;
            while(current != nextGroup) {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            
            prevGroup.next = kthElement;
            prevGroup = groupStart;
        }
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.ReverseKGroup(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 2);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.ReverseKGroup(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 3);
        Console.WriteLine("Result for case 2: " + result2);
    }
}

