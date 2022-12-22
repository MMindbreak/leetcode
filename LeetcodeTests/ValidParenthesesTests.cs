using Leetcode;
using NUnit.Framework;

namespace LeetcodeTests;

[TestFixture]
public class ValidParenthesesTests
{
    [Test]
    public void Test1()
    {
        var s = "()";
        var c = new ValidParentheses();
        var res = c.IsValid(s);
        
        Assert.That(res);
    }
    
    [Test]
    public void Test2()
    {
        var s = "()[]{}";
        var c = new ValidParentheses();
        var res = c.IsValid(s);
        
        Assert.That(res);
    }
    
    [Test]
    public void Test3()
    {
        var s = "(]";
        var c = new ValidParentheses();
        var res = c.IsValid(s);
        
        Assert.That(!res);
    }

    [Test]
    public void Test4()
    {
        var s = "([)]";
        var c = new ValidParentheses();
        var res = c.IsValid(s);
        
        Assert.That(!res);
    }

    [Test]
    public void Test5()
    {
        var s = "[";
        var c = new ValidParentheses();
        var res = c.IsValid(s);
        
        Assert.That(!res);
    }

    [Test]
    public void Test6()
    {
        var s = "]";
        var c = new ValidParentheses();
        var res = c.IsValid(s);
        
        Assert.That(!res);
    }
}