[assembly: CaptureConsole]

namespace LifecycleTest;

public class LifeCycleTest : IDisposable
{
    private readonly ITestOutputHelper output;

    public LifeCycleTest(ITestOutputHelper output)
    {
        this.output = output;
        this.output.WriteLine("Setup");
    }

    public void Dispose()
    {
        output.WriteLine("Teardown");
    }

    [Fact]
    public void MyTest01()
    {
        output.WriteLine("MyTest01");
    }

    [Fact]
    public void MyTest02()
    {
        output.WriteLine("MyTest02");
    }
}
