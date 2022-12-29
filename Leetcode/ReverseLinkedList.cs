using System.Security.Cryptography;

namespace Leetcode;

fpublic class ListNode {
    public int val;
    public ListNode? next;
     
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}
public class ReverseLinkedList
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null)
            return head;
        
        if (head.next == null)
            return head;
        
        ListNode cur = head;
        ListNode? prev = null;

        while (cur.next != null)
        {
            if (prev == null)
            {
                prev = cur;
                cur = cur.next;
                continue;
            }
            var next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next;
        }

        cur.next = prev;
        
        return cur;
    }
}