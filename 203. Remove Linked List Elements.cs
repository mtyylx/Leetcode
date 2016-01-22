/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        //主要难点在于各种corner case都能handle
        //例如第一个节点就等于val，例如中间连续好几个都等于val，不能轻易后移。因为单向链表一旦指针所指的节点就是val，是没法后悔的。
        
        //Solution 4: Use Dummy head to cover corner cases
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode curr = dummy;

        while (curr.next != null)
        {
            if (curr.next.val == val) curr.next = curr.next.next;
            else curr = curr.next;
        }
        return dummy.next;
        
        
        //Solution 3: Use recursion to solve this elegantly.
        //递归的好处就是可以只考虑当前节点，而不用担心一旦发现当前节点就是val的情况下没办法让上一个节点跳过当前节点。
        if(head == null) return null;
        //如果第一个节点就是val，那么就只对后面的链表进行递归，并且返回后面链表处理完后的第一个节点
        if(head.val == val) return RemoveElements(head.next, val);
        //如果第一个节点不是val，那么第一个节点后面的节点取决于对后面链表进行完递归后返回的第一个节点
        else head.next = RemoveElements(head.next, val);
        //到了这步，当前节点一定是处理完毕的。
        return head;
        

        //Solution 2: Handle scenario when head is val firstly, then handle the rest.
        while(head != null && head.val == val)
        {
            head = head.next;
        }
        ListNode cur = head;
        while(cur != null)
        {
            if(cur.next != null && cur.next.val == val) cur.next = cur.next.next;
            else cur = cur.next;
        }
        return head;
        

        //Solution 1: everything in one while loop, 
        //using continue to avoid execute "cur = cur.next" when it's possible that cur.next.next is still equal to val.
        while(cur != null)
        {
            if(cur.val == val)
            {
                head = head.next;
                cur = head;
                continue;
            }
            if(cur.next != null && cur.next.val == val)
            {
                cur.next = cur.next.next;
                continue;
            }
            cur = cur.next;
        }
        
        return head;
    }
}