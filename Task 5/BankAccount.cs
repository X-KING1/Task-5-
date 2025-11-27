// TASK 1: ENCAPSULATION

using System;

namespace BankAccountApp
{
    public class BankAccount
    {
        // private fields
        private string accountNumber;
        private double balance;

        // constructor
        public BankAccount(string accNum, double bal)
        {
            accountNumber = accNum;
            if (bal > 0)
            {
                balance = bal;
            }
            else
            {
                Console.WriteLine("Balance must be positive!");
                balance = 100; // default balance
            }
        }

        // property for AccountNumber (only get)
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // property for Balance with validation
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value > 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be negative or zero!");
                }
            }
        }

        // deposit method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
            }
            else
            {
                Console.WriteLine("Amount must be positive");
            }
        }

        // withdraw method
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance = balance - amount;
                }
                else
                {
                    Console.WriteLine("Not enough balance");
                }
            }
            else
            {
                Console.WriteLine("Amount must be positive");
            }
        }
    }
}
