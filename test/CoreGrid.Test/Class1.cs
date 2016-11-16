using Xunit;

namespace CoreGrid.Test
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void OkTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Theory]
        [InlineData(4), InlineData(6), InlineData(8)]
        public void NewTest(int value)
        {
            Assert.True(value % 2 == 0);
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }

}
