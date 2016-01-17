/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        //Solution 1: Concatenate two linked list, the intersection must be found after "|" (concatenation point)
        //一句话：拼起来就等长了
        //e.g. LinkedList A: a1, a2, a3, a4, a5, a6 | b1, b2, a5, a6
        //     LinkedList B: b1, b2, a5, a6 | a1, a2, a3, a4, a5, a6
        
        //e.g. LinkedList A: a1, a2, a3, a4, a5, a6 | b1, b2, b3, b4
        //     LinkedList B: b1, b2, b3, b4 | a1, a2, a3, a4, a5, a6
        
        //Impossible to have intersection if any of the two linked list are null, continue only if both of them are not null
        if(headA == null || headB == null)
            return null;
            
        ListNode A = headA;
        ListNode B = headB;
        
        //Stop loop when both A and B are null. (which means it has finished traverse twice)
        while(A != null || B != null)
        {
            if(A == null)
                A = headB;
            if(B == null)
                B = headA;
            //注意先后顺序:先跳转节点再比较是否相同
            if(A == B)      
                return A;
            A = A.next;
            B = B.next;
        }
        return null;
        
        
        //Solution 2: Get both length, so that we can align the two linked list by the tail.
        //In this case parallel move on will not be a problem.
        if(headA == null || headB == null)
            return null;
        
        int start = GetLength(headA) - GetLength(headB);
        for(int x = Math.Abs(start); x > 0; x--)
        {
            if(start > 0)
                headA = headA.next;
            if(start < 0)
                headB = headB.next;
        }

        while(headA != null && headB != null)
        {
            if(headA == headB)
                return headA;
            headA = headA.next;
            headB = headB.next;
        }
        return null;
    }
    
    private int GetLength(ListNode head)
    {
        int length = 0;
        while(head != null)
        {
            length++;
            head = head.next;
        }
        return length;
    }
}