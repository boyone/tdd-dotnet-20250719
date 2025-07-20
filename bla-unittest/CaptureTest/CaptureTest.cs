[assembly: CaptureConsole]

namespace CaptureTest;


public class CaptureTest(ITestOutputHelper output)
{

    [Fact]
    public void MyTest01()
    {
        output.WriteLine("MyTest01");
    }
}
