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

        if (head == null || head.next == null) return head;
        
        var prev = new ListNode(head.val, null);
        var curr = head.next;

        while (curr != null)
        {
            var temp = curr;   
            curr = curr.next; 
            temp.next = prev; 
            prev = temp;  
        }

        return prev;
    }
}
