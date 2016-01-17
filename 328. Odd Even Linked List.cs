/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode OddEvenList(ListNode head) {
        //Solution: Point head.next to head.next.next, cache head.next
        //Transform the LinkedList into two separate LinkedList then concatenate.
        
        //Early return if LinkedList length is less than 3
        if(head == null || head.next == null || head.next.next == null)
            return head;
            
        //Cache the evenHead, waiting to be pointed by the last odd node.
        ListNode evenHead = head.next;
        ListNode odd = head;
        ListNode even = evenHead;
        
        //The while loop condition is the key.
        //(even != null && even.next != null) means:
        //when even is null, condition = false, exit
        //when even is not null, and even.next is null, condition = false, exit
        //这个条件是怎么得出来的：观察链表长度为偶数和奇数两种情况下每次一个循环结束时两个指针的状态有什么规律
        // 1 -> 2 -> 3:         odd = 3, odd.next = null,   even = null, even.next = xxx
        // 1 -> 2 -> 3 -> 4:    odd = 3, odd.next = 4,      even = 4, even.next = null
        //从上面的总结可以看到，第二种情况odd无法用来作为循环终止的条件，除非继续loop
        //但是even在第一种和第二种都可以作为循环终止的条件
        
        
        //记住与和或运算做为循环终止条件的两种写法: !+&,=+|（可以做到隐式的避免空引用，即“A存在时才计算B”的特性）
        //Scenario 1: while(A != null && B != null) 仅在A和B均<存在>时才<运行>，A<存在>时才计算B是否<存在>, A<不存在>循环终止
        //Scenario 2: while(A == null || B == null) 仅在A和B均<存在>时才<不运行>，A<存在>时才计算B是否<不存在>, A<不存在>循环继续
        // A != null && B != null ---> Scenario 1
        // A != null && B == null ---> Scenario 2
        // A == null && B != null ---> Scenario 2
        // A == null && B == null ---> Scenario 2
        // 即 Scenario 1 + Scenario 2 = true.
        // 即 !Scenario 1 == Scenario 2
        // 依据性质 !(A&B) = (!A)|(!B)
        // !((A!=NULL)&&(B!=NULL)) --> (!(A!=NULL))||(!(B!=NULL)) --> (A==NULL)||(B==NULL)
        
        while(even != null && even.next != null)
        {
            odd.next = odd.next.next;
            odd = odd.next;
            even.next = even.next.next;
            even = even.next;
        }
        odd.next = evenHead;
        return head;
        
        
        //循环终止条件选的不好，导致code不简洁
        while(odd.next != null && even != null)
        {
            odd.next = odd.next.next;
            if(odd.next != null)
                odd = odd.next;
            else
            {
                odd.next = evenHead;
                break;
            }

            if(even.next != null)
                even.next = even.next.next;
            even = even.next;
        }
        odd.next = evenHead;
        return head;
    }
}