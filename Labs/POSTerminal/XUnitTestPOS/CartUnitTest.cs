using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using POSTerminal;

namespace XUnitTestPOS
{
    public class CartUnitTest
    {
        [Fact]
        public void Cart_Qty()
        {
            Inventory inventory = new Inventory();

            inventory.InitializeInventory();

            Cart cart = new Cart();

            cart.CartAdd(inventory.ReturnProducts(), 1, 2);

            int result = cart.ReturnCart().Count;

            Assert.Equal(1, result);
        }
    }
}
