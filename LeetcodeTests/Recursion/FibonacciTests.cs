using Leetcode.Recursion;

namespace LeetcodeTests.Recursion;

[TestFixture]
public class FibonacciTests
{
    [Test]
    public void Test1()
    {
        var fib = new Fibonacci();

        var res = fib.Fib(2);

        Assert.That(res, Is.EqualTo(1));
    }

    [Test]
    public void Test2()
    {
        var fib = new Fibonacci();

        var res = fib.Fib(4);

        Assert.That(res, Is.EqualTo(3));
    }
}