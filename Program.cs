using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I create a new bank account for a customer "John Doe" with an initial balance of 1000
            BankAccount account = new BankAccount("John Doe", 1000);

            // I test the deposit method with a valid deposit
            Console.WriteLine(account.Deposit(500));  // Valid deposit
            Console.WriteLine(account.Deposit(-200)); // Invalid deposit (negative amount)

            // I test the withdrawal method with different cases
            Console.WriteLine(account.Withdraw(300));  // Valid withdrawal
            Console.WriteLine(account.Withdraw(2000)); // Invalid withdrawal (insufficient funds)
            Console.WriteLine(account.Withdraw(-100)); // Invalid withdrawal (negative amount)

            // At the end, I display the final balance and list all transactions
            Console.WriteLine($"Final balance: ${account.Balance}");
            Console.WriteLine("Transactions:");
            foreach (var transaction in account.Transactions)
            {
                Console.WriteLine(transaction); // Display each transaction
            }
        }
    }
}
