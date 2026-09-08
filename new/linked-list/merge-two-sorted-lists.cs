// Pattern: Merge Two Sorted Lists
// When to use: Merging two sorted linked lists into one sorted linked list
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;
        
        while(list1 != null && list2 != null) {
            if(list1.val < list2.val) {
                tail.next = list1;
                tail = tail.next;
                list1 = list1.next;
            }
            else {
                tail.next = list2;
                tail = tail.next;
                list2 = list2.next;
            }
        }

        if(list1 != null) {
            tail.next = list1;
        }
        else if(list2 != null) {
            tail.next = list2;
        }

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
        var result1 = solution.MergeTwoLists(new ListNode(1, new ListNode(2, new ListNode(4))), new ListNode(1, new ListNode(3, new ListNode(4))));
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.MergeTwoLists(null, new ListNode(0));
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.MergeTwoLists(null, null);
        Console.WriteLine("Result for case 3: " + result3);
    }
}