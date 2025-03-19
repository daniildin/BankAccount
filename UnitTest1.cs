using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankAccountDemo;

namespace BankAccountTest
{
    [TestClass]
    public class BankAccountUnitTests
    {
        [TestMethod]
        public void Constructor_InitializesCorrectly()
        {
            // Arrange
            string customerName = "John Doe";
            decimal initialBalance = 1000m;

            // Act
            BankAccount account = new BankAccount(customerName, initialBalance);

            // Assert
            Assert.IsNotNull(account);
            Assert.AreEqual(customerName, account.CustomerName);
            Assert.AreEqual(initialBalance, account.Balance);
            Assert.AreEqual(0, account.Transactions.Count);
        }

        [TestMethod]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("John Doe", 1000m);

            // Act
            string result = account.Deposit(500m);

            // Assert
            Assert.AreEqual(1500m, account.Balance);
            Assert.AreEqual(1, account.Transactions.Count);
            StringAssert.Contains(result, "Deposited $500");
        }

        [TestMethod]
        public void Deposit_InvalidAmount_ReturnsError()
        {
            // Arrange
            BankAccount account = new BankAccount("John Doe", 1000m);

            // Act
            string result = account.Deposit(-100m);

            // Assert
            Assert.AreEqual(1000m, account.Balance);
            Assert.AreEqual(0, account.Transactions.Count);
            Assert.AreEqual("Deposit amount must be greater than zero.", result);
        }

        [TestMethod]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("John Doe", 1000m);

            // Act
            string result = account.Withdraw(200m);

            // Assert
            Assert.AreEqual(800m, account.Balance);
            Assert.AreEqual(1, account.Transactions.Count);
            StringAssert.Contains(result, "Withdrew $200");
        }

        [TestMethod]
        public void Withdraw_ExceedsBalance_ReturnsError()
        {
            // Arrange
            BankAccount account = new BankAccount("John Doe", 500m);

            // Act
            string result = account.Withdraw(600m);

            // Assert
            Assert.AreEqual(500m, account.Balance);
            Assert.AreEqual(0, account.Transactions.Count);
            Assert.AreEqual("Insufficient funds for withdrawal.", result);
        }

        [TestMethod]
        public void Withdraw_InvalidAmount_ReturnsError()
        {
            // Arrange
            BankAccount account = new BankAccount("John Doe", 1000m);

            // Act
            string result = account.Withdraw(-50m);

            // Assert
            Assert.AreEqual(1000m, account.Balance);
            Assert.AreEqual(0, account.Transactions.Count);
            Assert.AreEqual("Withdrawal amount must be greater than zero.", result);
        }

        [TestMethod]
        public void Transactions_AreRecordedCorrectly()
        {
            // Arrange
            BankAccount account = new BankAccount("John Doe", 1000m);

            // Act
            account.Deposit(300m);
            account.Withdraw(100m);
            account.Deposit(200m);

            // Assert
            Assert.AreEqual(3, account.Transactions.Count);
            StringAssert.Contains(account.Transactions[0], "Deposited: $300");
            StringAssert.Contains(account.Transactions[1], "Withdrew: $100");
            StringAssert.Contains(account.Transactions[2], "Deposited: $200");
        }
    }
}
