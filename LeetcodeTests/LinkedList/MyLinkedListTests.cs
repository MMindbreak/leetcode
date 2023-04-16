using Leetcode;
using NUnit.Framework;

namespace LeetcodeTests;

[TestFixture]
public class MyLinkedListTests
{
    [Test]
    public void TestGet()
    {
        // Arrange
        var list = new MyLinkedList();
        list.AddAtTail(1);
        list.AddAtTail(2);
        list.AddAtTail(3);

        // Act
        var val1 = list.Get(0);
        var val2 = list.Get(1);
        var val3 = list.Get(2);

        // Assert
        Assert.That(val1, Is.EqualTo(1));
        Assert.That(val2, Is.EqualTo(2));
        Assert.That(val3, Is.EqualTo(3));
    }
    
    [Test]
    public void TestAddAtHead()
    {
        // Arrange
        var list = new MyLinkedList();

        // Act
        list.AddAtHead(1);
        list.AddAtHead(2);
        list.AddAtHead(3);

        // Assert
        Assert.That(list.Get(0), Is.EqualTo(3));
        Assert.That(list.Get(1), Is.EqualTo(2));
        Assert.That(list.Get(2), Is.EqualTo(1));
    }
    
    [Test]
    public void TestAddAtTail()
    {
        // Arrange
        var list = new MyLinkedList();

        // Act
        list.AddAtTail(1);
        list.AddAtTail(2);
        list.AddAtTail(3);

        // Assert
        Assert.That(list.Get(0), Is.EqualTo(1));
        Assert.That(list.Get(1), Is.EqualTo(2));
        Assert.That(list.Get(2), Is.EqualTo(3));
    }
    
    [Test]
    public void TestAddAtIndex()
    {
        // Arrange
        var list = new MyLinkedList();
        list.AddAtTail(1);
        list.AddAtTail(3);

        // Act
        list.AddAtIndex(1, 2);

        // Assert
        Assert.That(list.Get(0), Is.EqualTo(1));
        Assert.That(list.Get(1), Is.EqualTo(2));
        Assert.That(list.Get(2), Is.EqualTo(3));
    }
    
    [Test]
    public void TestDeleteAtIndex()
    {
        // Arrange
        var list = new MyLinkedList();
        list.AddAtTail(1);
        list.AddAtTail(2);
        list.AddAtTail(3);

        // Act
        list.DeleteAtIndex(1);

        // Assert
        Assert.That(list.Get(0), Is.EqualTo(1));
        Assert.That(list.Get(1), Is.EqualTo(3));
    }

    [Test]
    public void TestDeleteAtIndex0()
    {
        var list = new MyLinkedList();
        list.AddAtHead(1);
        list.DeleteAtIndex(0);
        
        Assert.That(list.GetLength(), Is.EqualTo(0));
    }

    [Test]
    public void TestDothings()
    {
        var list = new MyLinkedList();
        list.AddAtHead(7);
        list.AddAtHead(2);
        list.AddAtHead(1);
        list.AddAtIndex(3, 0);
        list.DeleteAtIndex(2);
        list.AddAtHead(6);
        list.AddAtTail(4);
        var res = list.Get(4);
        list.AddAtHead(4);
        list.AddAtIndex(5, 0);
        list.AddAtHead(6);
        
        Assert.That(res, Is.EqualTo(4));
    }

    [Test]
    public void Idgaf()
    {
        var list = new MyLinkedList();
        list.AddAtHead(1);
        list.AddAtTail(3);
        list.AddAtIndex(1, 2);
        var res = list.Get(1);
        list.DeleteAtIndex(0);
        var res2 = list.Get(0);

        Assert.That(res, Is.EqualTo(2));
        Assert.That(res2, Is.EqualTo(2));
    }

    [Test]
    public void Idgaf2()
    {
        var list = new MyLinkedList();
        list.AddAtIndex(0, 10);
        list.AddAtIndex(0, 20);
        list.AddAtIndex(1, 30);
        var res = list.Get(0);
        Assert.That(res, Is.EqualTo(20));
    }

    [Test]
    public void Idgaf3()
    {
        MyLinkedList list = new MyLinkedList();
        
        list.AddAtHead(2);
        list.DeleteAtIndex(1);
        list.AddAtHead(2);
        list.AddAtHead(7);
        list.AddAtHead(3);
        list.AddAtHead(2);
        list.AddAtHead(5);
        list.AddAtTail(5);
        list.Get(5);
        list.DeleteAtIndex(6);
        list.DeleteAtIndex(4);

    }
}
