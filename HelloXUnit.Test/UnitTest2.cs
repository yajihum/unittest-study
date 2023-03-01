﻿using HelloXUnit.Test.Fixtures;

namespace HelloXUnit.Test
{
    [Collection("Heavy collection")]
    public class UnitTest2 : IDisposable
    {
        private readonly HeavyFixture _heavyFixture;

        public UnitTest2(HeavyFixture heavyFixture)
        {
            _heavyFixture = heavyFixture;
        }

        [Fact]
        public void Test() => _heavyFixture.Use();

        public void Dispose()
        {
            _heavyFixture.Dispose();
        }
    }
}
