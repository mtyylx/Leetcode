/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        
        //Solution 1: Recursive, not in-place
        //The Pros: no need to worry about the head pointer, because the recursive way will always protect the head.
        
        //Exit Condition: stop going deep if one of the "sub" list is null.
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        
        //If both sub list exist, go deeper. curHead is a separate new List who only pick the smaller one as its current node.
        ListNode curHead;
        if(l1.val < l2.val)
        {
            curHead = l1;
            curHead.next = MergeTwoLists(l1.next, l2);  //Recursive: 只考虑余下的链表部分
        }
        else
        {
            curHead = l2;
            curHead.next = MergeTwoLists(l1, l2.next);
        }
        return curHead;
        
        
        //Solution 2: Iterative
        //The tricky part is how to maintain the head of the merged list.
        //Here we use a fake dummy ListNode that has a random value, and the real merged list is started at dummy.next.
        
        //Create a random ListNode with insignificant value 0.
        ListNode merge = new ListNode(0);
        ListNode dummy = merge;
        while(l1 != null || l2 != null)
        {
            if(l1 == null)
            {
                merge.next = l2;
                break;
            }
            if(l2 == null)
            {
                merge.next = l1;
                break;
            }
            
            if(l1.val < l2.val)
            {
                merge.next = l1;
                l1 = l1.next;
            }
            else
            {
                merge.next = l2;
                l2 = l2.next;
            }
            merge = merge.next;    
        }
        return dummy.next;  //Remember to return dummy.next!
    }
}