using Xunit;
using System;

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
        [Fact]
        public void TestMethod2()
        {
            Product p = new Product("test", 100, new Category("test"), 33);
            Assert.Equal(67, p.Price);
        }
        [Fact]
        public void TestMethod3()
        {
            Product p = new Product("test", 100, new Category("test"));
            Assert.Throws<Exception>(() => p.Discount = 101);
        }
        [Fact]
        public void TestMethod4()
        {
            Product p = new Product("test", 100, new Category("test"));
            Assert.Throws<Exception>(() => p.Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        }
    }
}
