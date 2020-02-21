using System;
using Xunit;
using POSTerminal;

namespace XUnitTestPOS
{
    public class ProductUnitTest
    {
        [Fact]
        public void Product_Exists()
        {
            Product cutlass = new Product("Cutlass", 800);

            Assert.Equal("Cutlass", cutlass.ProductName);
            Assert.Equal(800, cutlass.ProductPrice);
        }
    }
}
