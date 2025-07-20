namespace LifecycleTest.Fixture;
public class MyFixture : IDisposable
{
    public string message { get; set; }

    public MyFixture()
    {
        message = "Hello";
    }

    public void Dispose()
    {
        message = "Bye";
    }
}

public class MyFixtureTest : IClassFixture<MyFixture>
{
    private readonly MyFixture fixture;

    public MyFixtureTest(MyFixture fixture)
    {
        this.fixture = fixture;
    }

    [Fact]
    public void ShouldShowHello()
    {
        Assert.Equal("Hello", fixture.message);
        fixture.message = "XXXX";
    }
}

public class MyFixtureTest2 : IClassFixture<MyFixture>
{
    private readonly MyFixture fixture;

    public MyFixtureTest2(MyFixture fixture)
    {
        this.fixture = fixture;
    }

    [Fact]
    public void ShouldShowHello()
    {
        Assert.Equal("Hello", fixture.message);
    }
}