namespace Leetcode;

public class MyLinkedList
{
    private Node _list;
    private Node _endNode;

    private LinkedList<int> _l = new LinkedList<int>();

    private int Length { get; set; }
    public int GetLength()
    {
        return Length;
    }
    
    public int Get(int index)
    {
        if (index >= Length)
            return -1;
        
        var c = 0;
        Node val = _list;
        
        while (c < index)
        {
            val = val.Next;
            c++;
        }

        return val.Val;
    }


    public void AddAtHead(int val)
    {
        var n = new Node()
        {
            Val = val,
            Next = _list
        };
        
        if (_list != null)
        {
            _list.Prev = n;    
        }

        _list = n;
        Length++;
    }

    public void AddAtTail(int val)
    {
        
        var n = _list;
        if (n == null)
        {
            _list = new Node()
            {
                Val = val
            };
            Length++;
            return;
        }
        while (n.Next != null)
        {
            n = n.Next;
        }

        n.Next = new Node()
        {
            Val = val,
            Prev = n
        };
        Length++;
    }

    public void AddAtIndex(int index, int val)
    {
        var node = _list;
        if (index > Length)
        {
            return;
        }
        if (index == Length)
        {
            AddAtTail(val);
            return;
        }

        if (index == 0)
        {
            AddAtHead(val);
            return;
        }
        for (int i = 0; i < index; i++)
        {
            node = node.Next;
        }

        var newNode = new Node()
        {
            Val = val
        };
        
        newNode.Next = node;
        newNode.Prev = node.Prev;
        node.Prev!.Next = newNode;
            
        node.Prev = newNode;
        
        
        Length++;
    }

    public void DeleteAtIndex(int index)
    {
        var node = _list;
        if (index >= Length)
        {
            return;
        }
        

        if (index == 0 && Length == 1)
        {
            _list = null;
            Length = 0;
            return;
        }
        
        if (index == 0)
        {
            _list = node.Next;
            Length--;
            return;
        }
        
        for (int i = 0; i < index ; i++)
        {
            node = node.Next;
        }
        
        if(node.Next != null)
            node.Next!.Prev = node.Prev;
        
        node.Prev!.Next = node.Next;

        Length--;
    }

    private class Node
    {
        public Node Next;
        public Node Prev;
        public int Val;
    }
}