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
        //�����������ô�ó����ģ��۲�������Ϊż�����������������ÿ��һ��ѭ������ʱ����ָ���״̬��ʲô����
        // 1 -> 2 -> 3:         odd = 3, odd.next = null,   even = null, even.next = xxx
        // 1 -> 2 -> 3 -> 4:    odd = 3, odd.next = 4,      even = 4, even.next = null
        //��������ܽ���Կ������ڶ������odd�޷�������Ϊѭ����ֹ�����������Ǽ���loop
        //����even�ڵ�һ�ֺ͵ڶ��ֶ�������Ϊѭ����ֹ������
        
        
        //��ס��ͻ�������Ϊѭ����ֹ����������д��: !+&,=+|������������ʽ�ı�������ã�����A����ʱ�ż���B�������ԣ�
        //Scenario 1: while(A != null && B != null) ����A��B��<����>ʱ��<����>��A<����>ʱ�ż���B�Ƿ�<����>, A<������>ѭ����ֹ
        //Scenario 2: while(A == null || B == null) ����A��B��<����>ʱ��<������>��A<����>ʱ�ż���B�Ƿ�<������>, A<������>ѭ������
        // A != null && B != null ---> Scenario 1
        // A != null && B == null ---> Scenario 2
        // A == null && B != null ---> Scenario 2
        // A == null && B == null ---> Scenario 2
        // �� Scenario 1 + Scenario 2 = true.
        // �� !Scenario 1 == Scenario 2
        // �������� !(A&B) = (!A)|(!B)
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
        
        
        //ѭ����ֹ����ѡ�Ĳ��ã�����code�����
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