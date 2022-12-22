using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Leetcode;

public class BaseballGame
{
    private Stack<int> _stack = new Stack<int>();
    public int CalPoints(string[] operations)
    {
        foreach (var op in operations)
        {
            int score;
            if (Int32.TryParse(op, out score))
            {
                _stack.Push(score);
            }

            if (op == "+")
            {
                var a = _stack.Pop();
                var b = _stack.Pop();
                var sum = a + b;
                _stack.Push(b);
                _stack.Push(a);
                _stack.Push(sum);
            }

            if (op == "D")
            {
                var prev = _stack.Peek();
                _stack.Push(prev * 2);
            }

            if (op == "C")
            {
                _stack.Pop();
            }
        }
        return _stack.ToArray().Sum();
    }
}