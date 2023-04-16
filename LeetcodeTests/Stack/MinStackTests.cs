using Leetcode;
using NUnit.Framework;

namespace LeetcodeTests;

[TestFixture]
public class MinStackTests
{
    [Test]
    public void Test1()
    {
        var c = new MinStack();
        c.Push(-2);
        c.Push(0);
        c.Push(-3);
        Assert.That(c.GetMin(), Is.EqualTo(-3));
        c.Pop();
        Assert.That(c.Top(), Is.EqualTo(0));
        Assert.That(c.GetMin(), Is.EqualTo(-2));
    }

    [Test]
    public void Test2()
    {
        var c = new MinStack();
        c.Push(0);
        c.Push(1);
        c.Push(0);
        Assert.That(c.GetMin(), Is.EqualTo(0));
        c.Pop();
        Assert.That(c.GetMin(), Is.EqualTo(0));
    }

    [Test]
    public void Test3()
    {
        var c = new MinStack();
        c.Push(2);
        c.Push(0);
        c.Push(3);
        c.Push(0);
        Assert.That(c.GetMin(), Is.EqualTo(0));
        c.Pop();
        Assert.That(c.GetMin(), Is.EqualTo(0));
        c.Pop();
        Assert.That(c.GetMin(), Is.EqualTo(0));
        c.Pop();
        Assert.That(c.GetMin(), Is.EqualTo(2));
    }
}