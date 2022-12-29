using Leetcode;
using NUnit.Framework;

namespace LeetcodeTests;

[TestFixture]
public class ReverseLinkedListTests
{
    [Test]
    public void Test1()
    {
        var list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var c = new ReverseLinkedList();
        var res = c.ReverseList(list);
        
        Assert.Multiple(() =>
        {
            Assert.That(res.val, Is.EqualTo(5));
            Assert.That(res.next.val, Is.EqualTo(4));
            Assert.That(res.next.next.val, Is.EqualTo(3));
            Assert.That(res.next.next.next.val, Is.EqualTo(2));
            Assert.That(res.next.next.next.next.val, Is.EqualTo(1));
        });
    }
}