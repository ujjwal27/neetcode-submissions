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
    public bool HasCycle(ListNode head) {
        var l1 = head;
        var l2 = head;

        while (l2 != null && l2.next != null)
        {
            l1 = l1.next;
            l2 = l2.next.next ;

            if (l1 == l2) return true;
        }

        return false;
    }
}
