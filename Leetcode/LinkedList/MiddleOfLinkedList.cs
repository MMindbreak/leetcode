namespace Leetcode;

public class MiddleOfLinkedList
{
    public ListNode MiddleNode(ListNode head)
    {
        var length = 0;
        var cur = head;
        while (cur != null)
        {
            cur = cur.next;
            length++;
        }

        var isEven = length % 2 == 0;

        var count = 1;
        while (head != null)
        {
            if (count * 2 >= length)
                if (isEven)
                    return head.next;
                else
                    return head;
            count++;
            head = head.next;
        }

        return head;
    }
}