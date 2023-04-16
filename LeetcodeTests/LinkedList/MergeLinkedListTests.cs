using Leetcode;
using NUnit.Framework;

namespace LeetcodeTests;

[TestFixture]
public class MergeLinkedListTests
{
    [Test]
    public void Test1()
    {
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var c = new MergeLinkedList();
        var res = c.MergeTwoLists(list1, list2);
        
        Assert.Multiple(() =>
        {
            Assert.That(res.val, Is.EqualTo(1));
            Assert.That(res.next.val, Is.EqualTo(1));
            Assert.That(res.next.next.val, Is.EqualTo(2));
            Assert.That(res.next.next.next.val, Is.EqualTo(3));
        });
    }
}