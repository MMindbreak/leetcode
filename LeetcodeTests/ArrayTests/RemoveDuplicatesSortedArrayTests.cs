using Leetcode;

namespace LeetcodeTests;

public class RemoveDuplicatesSortedArrayTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var nums = new[] { 1, 1, 2 };
        var c = new RemoveDuplicatesSortedArray();
        var res = c.RemoveDuplicates(nums);
    
        Assert.Multiple(() =>
        {
            Assert.That(res, Is.EqualTo(2));
            Assert.That(nums[0], Is.EqualTo(1));
            Assert.That(nums[1], Is.EqualTo(2));
        });
    }

    [Test]
    public void Test2()
    {
        var nums = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        var c = new RemoveDuplicatesSortedArray();
        var res = c.RemoveDuplicates(nums);
        Assert.Multiple(() =>
        {
            Assert.That(res, Is.EqualTo(5));
            Assert.That(nums[0], Is.EqualTo(0));
            Assert.That(nums[1], Is.EqualTo(1));
            Assert.That(nums[2], Is.EqualTo(2));
            Assert.That(nums[3], Is.EqualTo(3));
            Assert.That(nums[4], Is.EqualTo(4));
        });
    }

    [Test]
    public void Test3()
    {
        var nums = new[] { 1, 1, 1, 2 };
        var c = new RemoveDuplicatesSortedArray();
        var res = c.RemoveDuplicates(nums);
        Assert.Multiple(() =>
        {
            Assert.That(res, Is.EqualTo(2));
            Assert.That(nums[0], Is.EqualTo(1));
            Assert.That(nums[1], Is.EqualTo(2));
        });
    }
}