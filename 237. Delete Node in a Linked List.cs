/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        //Because we cannot retrieve the previous node, so we change the val of the current node, then point it to the next next node.
        //So infact we have deleted the next node, not the current node.
        //The next next node will have two node pointing at itself, the current node and the next node.
        if (node.next!=null)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}