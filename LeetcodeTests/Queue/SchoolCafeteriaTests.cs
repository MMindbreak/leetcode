using Leetcode.Queues;

namespace LeetcodeTests.Queue;

[TestFixture]
public class SchoolCafeteriaTests
{
    [Test]
    public void Test1()
    {
        int[] students = new[] { 1, 1, 0, 0 };
        int[] sandwiches = new[] { 0, 1, 0, 1 };
        var cls = new SchoolCafeteria();

        var res = cls.CountStudents(students, sandwiches);

        Assert.That(res, Is.EqualTo(0));
    }

    [Test]
    public void Test2()
    {
        int[] students = new[] { 1, 1, 1, 0, 0, 1 };
        int[] sandwiches = new[] { 1, 0, 0, 0, 1, 1 };

        var cls = new SchoolCafeteria();
        var res = cls.CountStudents(students, sandwiches);
        
        Assert.That(res, Is.EqualTo(3));
    }
}