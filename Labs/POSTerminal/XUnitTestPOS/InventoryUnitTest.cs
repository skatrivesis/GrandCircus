using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using POSTerminal;

namespace XUnitTestPOS
{
    public class InventoryUnitTest
    {
        [Fact]
        public void Inventory_Exists()
        {
            Inventory inventory = new Inventory();

            inventory.InitializeInventory();

            int result = inventory.ReturnProducts().Count;

            Assert.Equal(2, result);
        }
    }
}
