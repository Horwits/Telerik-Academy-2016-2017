using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExtensions;

namespace TestBank
{
    [TestClass]
    public class BankTests
    {
        [TestMethod]
        public void AccountsCount_IfIsEmptyWhenAddedNewAccount_ShouldAddOneAccountToAccountsCount()
        {
            // Arrange
            var bank = new Bank();
            var account = new Account();
            // Act
            bank.AddAccount(account);

            // Assert
            Assert.AreEqual<int>(1, bank.AccountsCount, "AccountsCount is not valid.");
        }

        [TestMethod]
        // [ExpectedException(typeof(ArgumentException))]
        public void AddAccount_IfNullValueIsPassed_ShouldThrowArgumentException()
        {
            var bank = new Bank();
            Account account = null;

            ThrowsAssert.Throws<ArgumentException>(() => bank.AddAccount(account));
        }

        // How to test a private unit of our class
        // All Private units should be tested through the public api.
        [TestMethod]
        public void TestPrivateUnits_WhenInit_ShouldReturnTwo()
        {
            PrivateObject pri = new PrivateObject(typeof(Bank));

            var num = pri.Invoke("TestPrivateUnits");

            Assert.AreEqual(2, num);
        }
    }
}
