using System.Text.RegularExpressions;

namespace Leetcode;

public class ValidParentheses
{
    private Stack<char> _stack = new();
    public bool IsValid(string s)
    {
        var close = new char[] { '}', ')', ']' };
        
        foreach (var c in s)
        {
            if (close.Contains(c))
            {
                char o;
                if (_stack.TryPeek(out o))
                {
                    switch (c)
                    {
                        case '}' when o != '{':
                        case ')' when o != '(':
                        case ']' when o != '[':
                            return false;
                        default:
                            _stack.Pop();
                            break;
                    }
                }
                else
                {
                    _stack.Push(c);
                }
            }
            else
            {
                _stack.Push(c);
            }
        }

        return _stack.Count == 0; 
    }
}