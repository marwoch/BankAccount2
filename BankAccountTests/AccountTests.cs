using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        Account acc;

        [TestInitialize()]
        public void InitTests()
        {
            acc = new Account();
        }


        /// <summary>
        /// initial positive balance test
        /// </summary>
        [TestMethod()]
        public void CreateAccountWithPositiveInitialBalance()
        {
            double initialBalance = 100;

            Account acc = new Account(initialBalance);

            Assert.AreEqual(initialBalance, acc.Balance);
        }

        /// <summary>
        /// initial negative balance test
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateAccountWithNegBalanceShouldThowException()
        {
            double initialBalance = -1;

            var acc = new Account(initialBalance);
        }

        [TestMethod()]
        [Priority(1)]
        [TestCategory("Deposit Tests")]
        public void DepositPositiveAmount()
        {
            //arrange
            InitTests();
            double initialBalance = 0;
            double depositAmount = 10;
            double expectedBalance = initialBalance + depositAmount;

            //act
            acc.Deposit(depositAmount);

            //assert
            Assert.AreEqual(expectedBalance, acc.Balance);

            ////make it fail until ready to code...
            //Assert.Fail();
        }

        [TestMethod()]
        [Priority(1)]
        [TestCategory("Deposit Tests")]
        [ExpectedException(typeof(ArgumentException))]
        public void DepositNegativeAmountShouldThrowException()
        {
            //arrange
            Account a = new Account();
            double depositAmount = -1;

            //act
            a.Deposit(depositAmount);

            //assert
                //assert is handled by expectedException attribute
        }

        [TestMethod()]
        [TestCategory("Withdrawl Tests")]
        public void WithdrawPositiveAmount()
        {
            Account acc = new Account();
            //arrange
            double initialBalance = 0;
            double withdrawAmount = 10;
            double expectedBalance = initialBalance - 10;
            //act
            acc.Withdrawl(withdrawAmount);
            //assert
            Assert.AreEqual(expectedBalance, acc.Balance);
        }

        [TestMethod()]
        [TestCategory("Withdrawl Tests")]
        [ExpectedException(typeof(ArgumentException))]
        public void WithdrawNegativeAmountShouldThrowException()
        {
            Account acc = new Account();

            double withdrawAmount = -10;

            acc.Withdrawl(withdrawAmount);
        }
    }
}