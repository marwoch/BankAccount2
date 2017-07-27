using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// This represents a bank account
    /// </summary>
    public class Account
    {
        private double balance;

        public Account()
        {

        }

        public double Balance
        {
            get { return balance; }
        }

        /// <summary>
        /// Adds an amount to the balance
        /// </summary>
        /// <param name="amt">the amount to be added</param>
        public void Deposit(double amt)
        {
            if (amt > 0)
            {
                balance += amt;
            }
            else
            {
                throw new ArgumentException("Deposit amount must be a positive number");
            }

        }

        /// <summary>
        /// subtracts an amount from the balance
        /// </summary>
        /// <param name="amt">the amount to be withdrawn</param>
        public void Withdrawl(double amt)
        {
            balance += amt;
        }
    }
}
