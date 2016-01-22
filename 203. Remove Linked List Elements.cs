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
        //��Ҫ�ѵ����ڸ���corner case����handle
        //�����һ���ڵ�͵���val�������м������ü���������val���������׺��ơ���Ϊ��������һ��ָ����ָ�Ľڵ����val����û����ڵġ�
        
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
        //�ݹ�ĺô����ǿ���ֻ���ǵ�ǰ�ڵ㣬�����õ���һ�����ֵ�ǰ�ڵ����val�������û�취����һ���ڵ�������ǰ�ڵ㡣
        if(head == null) return null;
        //�����һ���ڵ����val����ô��ֻ�Ժ����������еݹ飬���ҷ��غ������������ĵ�һ���ڵ�
        if(head.val == val) return RemoveElements(head.next, val);
        //�����һ���ڵ㲻��val����ô��һ���ڵ����Ľڵ�ȡ���ڶԺ������������ݹ�󷵻صĵ�һ���ڵ�
        else head.next = RemoveElements(head.next, val);
        //�����ⲽ����ǰ�ڵ�һ���Ǵ�����ϵġ�
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