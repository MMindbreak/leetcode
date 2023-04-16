using Leetcode.Queues;

namespace LeetcodeTests.Queue;

[TestFixture]
public class QueueAsStackTests
{
    [Test]
    public void Test1()
    {
        var qas = new QueueAsStack();
        qas.Push(1);
        qas.Push(2);
        var res1 = qas.Top();
        var res2 = qas.Pop();
        var res3 = qas.Empty();
        
        Assert.That(res1, Is.EqualTo(2));
        Assert.That(res2, Is.EqualTo(2));
        Assert.That(res3, Is.False);
    }
}