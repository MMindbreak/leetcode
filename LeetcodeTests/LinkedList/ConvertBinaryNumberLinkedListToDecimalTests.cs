using Leetcode;
using NUnit.Framework;

namespace LeetcodeTests;

[TestFixture]
public class ConvertBinaryNumberLinkedListToDecimalTests
{
    [Test]
    public void Test1()
    {
        var head = new ListNode(1, new ListNode(0, new ListNode(1)));
        var c = new ConvertBinaryNumberLinkedListToDecimal();
        var res = c.GetDecimalValue(head);
        
        Assert.That(res, Is.EqualTo(5));
    }
}