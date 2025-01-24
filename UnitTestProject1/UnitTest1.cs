using System.Diagnostics;

namespace UnitTestProject1;

public class Tests

{
    [SetUp]

    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {

        var a = 1;
        var b = 2;
        Assert.AreEqual(3, a + b);
        var c = 1;
        Assert.IsTrue(c == 1);
        Assert.Pass();
        var d = 1;
        Assert.AreNotEqual(1, a);

    }

    private void Quiz()
    {
        var a = 3;
        var b = 2;
        var c = 1;
        Assert.AreEqual(5, a + b);
        Assert.AreEqual(2, c + c);
        Assert.AreNotEqual(5, a);
        Assert.Fail("this should fail");
    }
}