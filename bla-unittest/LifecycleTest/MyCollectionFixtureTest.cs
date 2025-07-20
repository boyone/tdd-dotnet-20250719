namespace collectionfixture;

public class MyCollectionFixture : IDisposable
{
    public string message { get; set; }

    public MyCollectionFixture()
    {
        message = "Hello";
    }

    public void Dispose()
    {
        message = "Bye";
    }
}

[CollectionDefinition("MyCollectionFixture collection")]
public class MyCollectionFixtureDefinition : ICollectionFixture<MyCollectionFixture>
{
    
}

[Collection("MyCollectionFixture collection")]
public class MyCollectionFixtureTest
{
    private readonly MyCollectionFixture fixture;

    public MyCollectionFixtureTest(MyCollectionFixture fixture)
    {
        this.fixture = fixture;
    }

    [Fact]
    public void MyTest01()
    {
        Assert.Equal("Hello", fixture.message);
    }
}

[Collection("MyCollectionFixture collection")]
public class MyCollectionFixtureTest2
{
    private readonly MyCollectionFixture fixture;

    public MyCollectionFixtureTest2(MyCollectionFixture fixture)
    {
        this.fixture = fixture;
    }

    [Fact]
    public void MyTest01() {
        Assert.Equal("Hello", fixture.message);
    }

    [Fact]
    public void MyTest02() {
        Assert.Equal("Hello", fixture.message);
    }
}
