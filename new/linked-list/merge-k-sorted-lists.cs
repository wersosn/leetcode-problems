// 1.
// Pattern: Brute force approach of repeatedly finding the minimum element among all lists
// When to use: When you have a small number of sorted linked lists or when simplicity is preferred over efficiency
// Complexity: O(N * k) time, O(1) space, where N is the total number of nodes and k is the number of lists

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
    public ListNode MergeKListsBruteForce(ListNode[] lists) {      
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;
           
        while(true) {
            ListNode minNode = null;
            int minIndex = -1;

            for(int i = 0; i < lists.Length; i++) {
                if(lists[i] == null) {
                    continue;
                }

                if(minNode == null || lists[i].val < minNode.val) {
                    minNode = lists[i];
                    minIndex = i;
                }
            }

            if(minNode == null) {
                return dummy.next;
            }
            else {
                tail.next = minNode;
                tail = tail.next;
                lists[minIndex] = lists[minIndex].next;
            }
        }
    }
}

// 2.
// Pattern: Using a priority queue (min-heap) to efficiently retrieve the smallest element among all lists
// When to use: When you have k sorted linked lists and want to merge them into one sorted linked list
// Complexity: O(N * log k) time, O(k) space, where N is the total number of nodes and k is the number of lists
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {      
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;
        PriorityQueue<ListNode, int> queue = new PriorityQueue<ListNode, int>();
           
        foreach(var list in lists) {
            if(list != null) {
                queue.Enqueue(list, list.val);
            }
            else {
                continue;
            }
        }

        while(queue.Count > 0) {
            var node = queue.Dequeue();
            tail.next = node;
            tail = tail.next;
            if(node.next != null) {
                queue.Enqueue(node.next, node.next.val);
            }
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
        var result1 = solution.MergeKLists(new ListNode[] {
            new ListNode(1, new ListNode(4, new ListNode(5))),
            new ListNode(1, new ListNode(3, new ListNode(4))),
            new ListNode(2, new ListNode(6))
        });
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.MergeKLists(new ListNode[] { null, new ListNode(0) });
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.MergeKLists(new ListNode[] { null, null });
        Console.WriteLine("Result for case 3: " + result3);
    }
}