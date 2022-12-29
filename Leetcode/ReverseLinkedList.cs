namespace Leetcode;

public class ListNode {
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
        if (head.next == null)
            return head;

        var cur = head;
        var next = cur.next;
        while (cur.next != null)
        {
            next.next = cur;
            cur = next;
            next = next.next;
        }

        return cur;
    }
}