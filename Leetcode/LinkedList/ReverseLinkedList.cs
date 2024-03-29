using System.Security.Cryptography;

namespace Leetcode;

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode next = null)
    {
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

        while (cur != null)
        {
            var next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next;
        }

        return prev;
    }
}