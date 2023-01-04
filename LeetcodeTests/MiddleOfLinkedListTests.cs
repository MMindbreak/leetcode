using Leetcode;
using NUnit.Framework;

namespace LeetcodeTests;

[TestFixture]
public class MiddleOfLinkedListTests
{
    [Test]
    public void Test1()
    {
        var list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var c = new MiddleOfLinkedList();
        var res = c.MiddleNode(list);

        Assert.That(res.val, Is.EqualTo(3));
    }
    
    [Test]
    public void Test2()
    {
        var list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))));
        var c = new MiddleOfLinkedList();
        var res = c.MiddleNode(list);

        Assert.That(res.val, Is.EqualTo(4));
    }
}