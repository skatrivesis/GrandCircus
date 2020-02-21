using System;
using POSTerminal;
using Xunit;

namespace XUnitTestPOS
{
    public class TransactionUnitTest
    {
        [Fact]
        public void Transaction_CalculateTransaction()
        {
            Inventory inventory = new Inventory();
            Transaction transaction = new Transaction();

            inventory.InitializeInventory();

            Cart cart = new Cart();

            cart.CartAdd(inventory.ReturnProducts(), 0, 2);

            double result = transaction.CalculateTransaction(inventory.ReturnProducts(), cart.ReturnCart());


            Assert.Equal(1696, result);
        }


    }
}
