using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXUnit.Test.Fixtures
{
    public class AsyncHeavyFixture : IAsyncLifetime
    {
        public Task InitializeAsync() => Task.Delay(TimeSpan.FromSeconds(2));

        public void Use()
        {
        }

        public Task DisposeAsync() => Task.Delay(TimeSpan.FromSeconds(2));
    }
}
