namespace Leetcode.Recursion;

public class Fibonacci
{
    private Dictionary<int, int> _cache = new Dictionary<int, int>();
    public int Fib(int n)
    {
        if (_cache.ContainsKey(n))
            return _cache[n];
        
        if (n == 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 1;
        }
        else
        {
            var f1 = Fib(n - 1);
            var f2 = Fib(n - 2);
            _cache[n - 1] = f1;
            _cache[n - 2] = f2;
            return f1 + f2;
        }
    }
}