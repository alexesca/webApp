using Xunit;
namespace unit_test
{
    public class Class1
    {
        [fact]
        public void failingTest()
        {
            Assert.False(true);
        }
    }
}
