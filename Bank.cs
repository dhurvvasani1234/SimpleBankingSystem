using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Bank
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            int months = 0;
            bool flag = false;

            while(!flag)
            {
                // prompt user for number of deposit
                Console.Write("Enter number of months to deposit: ");
                string depositInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(depositInput))
                {

                    // update months value with user input
                    months = int.Parse(depositInput);

                    // iterate until flag is true
                    while (true)
                    {
                        // prompt user for customer details
                        Console.Write("\nEnter Customer\'s Name: ");
                        string customerName = Console.ReadLine();

                        // check if user has not entered any data
                        if (string.IsNullOrEmpty(customerName) && accounts.Count == 0)
                        {
                            Console.WriteLine("No data entered. Please enter at least one account details\n");
                        } // if ends

                        // if user has entered data
                        else if (string.IsNullOrEmpty(customerName) && accounts.Count > 0)
                        {
                            // iterate through account objects
                            foreach (Account account in accounts)
                            {
                                // iterate through number of months
                                for (int index = 0; index < months; index++)
                                {
                                    // deduct monthly fee - withdraw
                                    account.Withdraw(account.AccountMonthlyFee);
                                    // add monthly interest - deposit
                                    account.Deposit(account.CustomerBalance * account.AccountMonthlyInterestRate);
                                    // add monthly deposit - deposit
                                    account.Deposit(account.CustomerMonthlyDepositAmount);
                                }
                            }

                            // iterate through account objects and print result
                            foreach (Account account in accounts)
                            {
                                Console.Write("\nAfter {0} month(s), {1}\'s account (#{2}), has a balance of: {3:C}", months, account.CustomerOwnerName, account.CustomerAccountNumber, account.CustomerBalance);
                            }
                            Console.WriteLine("\nPress Enter to complete");

                            // update boolean flag
                            flag = true;
                            break;
                        }// else-if ends

                        // default condition
                        else
                        {
                            Console.Write("Enter {0}\'s Initial Deposit Amount (minimum $1,000.00): ", customerName);
                            double initialDepositAmount = double.Parse(Console.ReadLine());

                            Console.Write("Enter {0}\'s Monthly Deposit Amount (minimum $50.00): ", customerName);
                            double mDepositAmount = double.Parse(Console.ReadLine());

                            // create an object with parameters for Account and assign properties
                            Account acc = new Account(customerName, initialDepositAmount, mDepositAmount);
                            // add account details
                            accounts.Add(acc);

                        } // else ends
                    }
                } else
                {

                    Console.WriteLine("Please enter number of months to deposit\n");
                }
            }
        }
    }
}
