using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Account
    {
        private int AccountNumber = 0;
        private string OwnerName = "";
        private double Balance;
        private double MonthlyDepositAmount;
        private static double MonthlyFee = 4.0;
        private static double MonthlyInterestRate = 0.0025;
        private static double MinimumInitialBalance = 1000;
        private static double MinimumMonthDeposit = 50;

        // default constructor
        public Account()
        {
            // initialize balance with 1000
            Balance = MinimumInitialBalance;
            // initalize montly deposit with 50
            MonthlyDepositAmount = MinimumMonthDeposit;
            // generate a 5-digit random number between 90000 - 99999
            AccountNumber = new Random().Next(90000, 99999);
        }

        // constructor with owner's name, balance
        public Account(string OwnerName, double Balance)
        {
            // initialize owner name
            this.OwnerName = OwnerName;
            // initialize balance
            this.Balance = Balance;
            // initalize montly deposit with 50
            MonthlyDepositAmount = MinimumMonthDeposit;
            // generate a 5-digit random number between 90000 - 99999
            AccountNumber = new Random().Next(90000, 99999);
        }

        // constructor with owner's name, balance, monthly deposit
        public Account(string OwnerName, double Balance, double MonthlyDepositAmount)
        {
            // initialize owner name
            this.OwnerName = OwnerName;
            // initialize balance
            this.Balance = Balance;
            // initalize montly deposit with 50
            this.MonthlyDepositAmount = MonthlyDepositAmount;
            // generate a 5-digit random number between 90000 - 99999
            AccountNumber = new Random().Next(90000, 99999);
        }

        // properties
        public int CustomerAccountNumber { get { return AccountNumber; } }
        public string CustomerOwnerName { get { return OwnerName; } }
        public double CustomerBalance { get { return Balance; } }
        public double CustomerMonthlyDepositAmount { get { return MonthlyDepositAmount; } }
        public double AccountMonthlyFee { get { return MonthlyFee; } }
        public double AccountMonthlyInterestRate { get { return MonthlyInterestRate; } }

        // methods
        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (this.Balance < amount)
            {
                throw new Exception("Invalid! Withdraw amount cannot be less than the Balance");
            }

            // otherwise
            Balance -= amount;
        }
    }
}
