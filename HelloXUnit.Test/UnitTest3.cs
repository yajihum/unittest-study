using HelloXUnit.Test.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXUnit.Test
{
    public class UnitTest3 : IClassFixture<AsyncHeavyFixture>
    {
        private readonly AsyncHeavyFixture _asyncHeavyFixture;

        public UnitTest3(AsyncHeavyFixture asyncAsyncHeavyFixture)
        {
            _asyncHeavyFixture = asyncAsyncHeavyFixture;
        }

        [Fact]
        public void Test() => _asyncHeavyFixture.Use();
    }
}
