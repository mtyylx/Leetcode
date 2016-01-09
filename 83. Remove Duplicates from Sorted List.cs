/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        //Protect head, so that we can return the Linked List after processing.
        ListNode cur = head;
        
        //End loop if Linked List is empty or reached tail.
        while(cur!=null)
        {
            //Skip (delete) next node if value are the same.
            if(cur.next != null && cur.val == cur.next.val)
            {
                cur.next = cur.next.next;
            }
            //Only when next node has different value shall we move on.
            else
                cur = cur.next;
        }
        
        return head;
        
    }
}