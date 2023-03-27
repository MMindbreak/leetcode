namespace Leetcode;

public class ConvertBinaryNumberLinkedListToDecimal
{
    public int GetDecimalValue(ListNode head)
    {
        var res = 0;
        var bitLength = 0;
        var cur = head;
        while (cur != null)
        {
            cur = cur.next;
            bitLength++;
        }

        cur = head;
        while (cur != null)
        {
            bitLength--;
            res = res + cur.val * (int) Math.Pow(2.0, (double)bitLength);
            cur = cur.next;
        }

        return res;
        
    }
}