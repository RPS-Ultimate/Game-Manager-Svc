using System;
using Xunit;

namespace GameManager_Tests
{
    public class UnitTest1
    {
        private readonly bool _test;

        public UnitTest1()
        {
            _test = true;
        }

        [Fact]
        public void Returns_False()
        {
            Assert.True(_test);
        }
    }
}
