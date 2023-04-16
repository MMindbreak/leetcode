using System.Collections;

namespace Leetcode.Queues;

public class SchoolCafeteria
{
    private Stack<int> _sandwiches = new Stack<int>();
    private Queue<int> _students = new Queue<int>();
    public int CountStudents(int[] students, int[] sandwiches)
    {
        _sandwiches = new Stack<int>(sandwiches.Reverse());
        _students = new Queue<int>(students);

        var count = 0;
        while (_sandwiches.Count > 0 && _students.Count > 0 && count != _students.Count)
        {
            if (_students.Peek().Equals(_sandwiches.Peek()))
            {
                _students.Dequeue();
                _sandwiches.Pop();
                count = 0;
            }
            else
            {
                count++;
                var s = _students.Dequeue();
                _students.Enqueue(s);
            }
            
        }
        
        return _students.Count;
    }
}