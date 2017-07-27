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
        [TestMethod()]
        public void DepositPositiveAmount()
        {
            //arrange
            Account acc = new Account();
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
    }
}