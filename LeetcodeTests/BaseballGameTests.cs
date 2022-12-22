using Leetcode;
using NUnit.Framework;

namespace LeetcodeTests;

[TestFixture]
public class BaseballGameTests
{
    [Test]
    public void Test1()
    {
        var ops = new string[] { "5","2","C","D","+" };
        var c = new BaseballGame();
        var res = c.CalPoints(ops);
        
        Assert.That(res, Is.EqualTo(30));
    }

    [Test]
    public void Test2()
    {
        var ops = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };
        var c = new BaseballGame();
        var res = c.CalPoints(ops);
        
        Assert.That(res, Is.EqualTo(27));
    }
    
}