using System;
using Xunit;

namespace xUnitTesting.Tests
{
    public class CalcTest
    {
        [Fact]
        public void Add_WhenPassToInteger_ReturnsSum()
        {
            var x = 2;
            var y = 5;

            var result = new Calc().Add(x,y);

            Assert.Equal(x+y, result);
        }
    }
}
