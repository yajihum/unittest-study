using HelloXUnit.Test.Fixtures;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Xunit.Abstractions;

namespace HelloXUnit.Test
{
    [Collection("Heavy collection")]
    public class UnitTest1 : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private readonly HeavyFixture _heavyFixture;

        public UnitTest1(ITestOutputHelper output, HeavyFixture heavyFixture)
        {
            _heavyFixture = heavyFixture;

            _output = output;
            _output.WriteLine("This is output from {0}", "Constructor");
        }

        [Fact]
        public void Test1()
        {
            _heavyFixture.Use();
            _output.WriteLine("This is output from {0}", "Test1");
        }

        [Fact]
        public void Test2() => _heavyFixture.Use();

        public void Dispose()
        {
            //_heavyFixture.Dispose();
        }
    }
}
