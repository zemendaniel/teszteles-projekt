using Xunit;

namespace Product.Test
{
    public class UnitTests
    {
        [Fact]
        public void TestMethod1()
        {
            Product p = new Product("test", 100, new Category("test"), 50);
            Assert.Equal(50, p.Price);
        }
        
    }
}
