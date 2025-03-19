using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountDemo
{

    public class BankAccount
    {
        // I use this property to hold the unique account ID
        public string AccountId { get; private set; }

        // This stores the customer's name (I set it when the account is created)
        public string CustomerName { get; private set; }

        // This keeps track of the balance in the account
        public decimal Balance { get; private set; }

        // I use this list to store all transaction details (deposits and withdrawals)
        public List<string> Transactions { get; private set; }

        // I set up the account with a customer name and initial balance
        public BankAccount(string customerName, decimal initialBalance)
        {
            // I create a unique account ID using a random number
            AccountId = "ACC" + new Random().Next(100000, 999999).ToString();
            CustomerName = customerName;
            Balance = initialBalance;
            Transactions = new List<string>();
        }

        // This method allows me to deposit money into the account
        public string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "Deposit amount must be greater than zero.";

            Balance += amount;
            Transactions.Add($"Deposited: ${amount}"); // I record the deposit transaction
            return $"Deposited ${amount}. New balance: ${Balance}";
        }

        // This method lets me withdraw money from the account
        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
                return "Withdrawal amount must be greater than zero.";

            if (amount > Balance)
                return "Insufficient funds for withdrawal."; // I check if there's enough money

            Balance -= amount;
            Transactions.Add($"Withdrew: ${amount}"); // I record the withdrawal transaction
            return $"Withdrew ${amount}. New balance: ${Balance}";
        }
    }

}
