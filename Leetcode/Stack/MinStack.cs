namespace Leetcode;

public class MinStack
{
    private Stack<int> _stack = new();
    private List<int> _minValues = new(); 
    public MinStack()
    {
        
    }

    public void Push(int val)
    {
        if (_minValues.Count > 0)
        {
            if (val <= _minValues.Last())
                _minValues.Add(val);
        }
        else
        {
            _minValues.Add(val);
        }
            
        
        _stack.Push(val);
    }

    public void Pop()
    {
        
        var p = _stack.Pop();
        if(_minValues.Count > 0)
            if (p == _minValues.Last())
                _minValues.RemoveAt(_minValues.Count - 1);
    }

    public int Top()
    {
        return _stack.Peek();
    }

    public int GetMin()
    {
        return _minValues.LastOrDefault();
    }
}