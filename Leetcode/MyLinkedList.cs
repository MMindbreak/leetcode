namespace Leetcode;

public class MyLinkedList
{
    private class Node
    {
        public int Val;
        public Node Next;
        public Node Prev;
    }

    private Node _list;
    private int _length;
    public MyLinkedList()
    {
        _list = new Node();
        _length = 0;
    }
    
    public int Get(int index)
    {
        var p = _list;
        while (index > 0)
        {
            index--;
            p = p.Next;
        }

        return p.Next.Val;
    }
    
    public void AddAtHead(int val)
    {
        var n = new Node() { Val = val, Next = _list };
        _list = n;
        _length++;
    }
    
    public void AddAtTail(int val)
    {
        
        _length++;
        var p = _list;
        while (p.Next != null)
        {
            p = p.Next;
        }

        p.Next = new Node() { Val = val, Prev = p};
    }
    
    public void AddAtIndex(int index, int val)
    {
        if (index > _length)
            return;
        
        _length++;
        var p = _list;
        while (index > 0)
        {
            index--;
            p = p.Next;
        }

        var n = new Node()
        {
            Val = val,
            Prev = p,
            Next = p.Next
        };

        p.Next = n;
        n.Next.Prev = n;
    }
    
    public void DeleteAtIndex(int index)
    {
        if (index > _length)
            return;
        
        _length--;
        
        var p = _list;
        while (index > 0)
        {
            index--;
            p = p.Next;
        }

        p.Next = p.Next.Next;
    }
}