using NUnit.Framework;


[TestFixture]
public class DynamicTests
{
    public string Foo;
    [Test]
    [Ignore]
    public void NoProperty()
    {
        dynamic x = "aString";
        x.Foo = "aString";
    }
    [Test]
    [Ignore]
    public void WrongType()
    {
        dynamic x = new DynamicTests();
        x.Foo = 1;
    }
}