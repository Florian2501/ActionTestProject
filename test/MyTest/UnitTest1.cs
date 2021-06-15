using System;
using Xunit;

namespace MyTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestMultiply()
        {
            int a = 2;
            int b= 34;
            int expected = 68;

            int state = Testlib.Class1.multiply(a,b);
            Assert.Equal(expected, state);
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(-1,4,3)]
        public void TestAdd(int a, int b, int result){
            int state = Testlib.Class1.add(a,b);
            Assert.Equal(result, state);
        }
    }
}
