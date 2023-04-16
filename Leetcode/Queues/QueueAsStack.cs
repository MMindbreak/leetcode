namespace Leetcode.Queues;

public class QueueAsStack
{
    private Queue<int> _queueA = new Queue<int>();
    private Queue<int> _queueB = new Queue<int>();
    
    public void Push(int x) {
        _queueA.Enqueue(x);
    }
    
    public int Pop()
    {
        while (_queueA.Count > 1)
        {
            _queueB.Enqueue(_queueA.Dequeue());
        }

        var o = _queueA.Dequeue();
        while (_queueB.Count > 0)
        {
            _queueA.Enqueue(_queueB.Dequeue());
        }

        return o;
    }
    
    public int Top()
    {
        while (_queueA.Count > 1)
        {
            _queueB.Enqueue(_queueA.Dequeue());
        }

        var o = _queueA.Dequeue();
        while (_queueB.Count > 0)
        {
            _queueA.Enqueue(_queueB.Dequeue());
        }
        _queueA.Enqueue(o);

        return o;
    }
    
    public bool Empty()
    {
        return _queueA.Count == 0;
    }
    
}