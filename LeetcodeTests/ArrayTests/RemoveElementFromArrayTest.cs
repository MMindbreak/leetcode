  using Leetcode;
using NuGet.Frameworks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace LeetcodeTests;

[TestFixture]
public class RemoveElementFromArrayTest
{
    [Test]
    public void Test1()
    {
        var nums = new int[] { 3, 2, 2, 3 };
        var val = 3;
        var c = new RemoveElementFromArray();
        var res = c.RemoveElement(nums, val);

        Assert.Multiple(() =>
        {
            Assert.That(res, Is.EqualTo(2));
            Assert.That(nums[0], Is.EqualTo(2));
            Assert.That(nums[1], Is.EqualTo(2));
        });
    }

    [Test]
    public void Test2()
    {
        var nums = new int[] {0,1,2,2,3,0,4,2};
        var val = 2;
        var c = new RemoveElementFromArray();
        var res = c.RemoveElement(nums, val);

        Assert.Multiple(() =>
        {
            Assert.That(res, Is.EqualTo(5));
            Assert.That(nums[0], !Is.EqualTo(2));
            Assert.That(nums[1], !Is.EqualTo(2));
            Assert.That(nums[2], !Is.EqualTo(2));
            Assert.That(nums[3], !Is.EqualTo(2));
            Assert.That(nums[4], !Is.EqualTo(2));
        });
    }

    [Test]
    public void Test3()
    {
        var nums = new int[0];
        var val = 1;
        var c = new RemoveElementFromArray();
        var res = c.RemoveElement(nums, val);
        Assert.That(res, Is.EqualTo(0));
    }

    [Test]
    public void Test4()
    {
        var nums = new int[] { 1 };
        var val = 1;
        var c = new RemoveElementFromArray();
        var res = c.RemoveElement(nums, val);
        Assert.That(res, Is.EqualTo(0));
    }

    [Test]
    public void Test5()
    {
        var nums = new int[] { 3, 3 };
        var val = 3;
        var c = new RemoveElementFromArray();
        var res = c.RemoveElement(nums, val);
        Assert.That(res, Is.EqualTo(0));
    }

    [Test]
    public void Test6()
    {
        var nums = new int[] { 4, 5 };
        var val = 4;
        var c = new RemoveElementFromArray();
        var res = c.RemoveElement(nums, val);
        Assert.Multiple(() =>
        {
            Assert.That(res, Is.EqualTo(1));
            Assert.That(nums[0], Is.EqualTo(5));
        });
    }
}