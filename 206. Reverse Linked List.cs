/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        //old head.next should point at null to mark as tail.
        ListNode prevNode = null;
        ListNode nextNode = null;
        while(head != null)
        {
            //Update Next Node (buffer Current Node's Next)
            nextNode = head.next;
            //Update Current Node's Next: Now head.next point at Previous Node
            head.next = prevNode;
            //So far the job on Current Node is done, now move on to next node.
            
            //Update Previous Node: Current Node now become Previous Node
            prevNode = head;
            //Update Current Node: Next Node now become Current Node (for next iteration)
            head = nextNode;
            
            //Basically it is just a 4 variables SWAP;
            // <1> nextNode
            // <2> head.next
            // <3> prevNode
            // <4> head
            // <1> << <2>
            // <2> << <3>
            // <3> << <4>
            // <4> << <1>
        }
        return prevNode;
    }
}