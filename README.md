![image](https://github.com/user-attachments/assets/22c9c814-7d8e-42e3-8fd7-f5e611210d4e)




# BankAccount Program

This is a simple bank account program written in C#. It includes a `BankAccount` class that supports deposits, withdrawals, and tracks transactions.

## Features

- **BankAccount Class**: Represents a customer's bank account with balance tracking and transaction history.
- **Deposit Method**: Allows deposits into the account.
- **Withdraw Method**: Allows withdrawals from the account with sufficient funds.
- **Transaction History**: Records all deposits and withdrawals.

## How to Run

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or your preferred C# IDE.
3. Build the solution.
4. Run the `Program.cs` to interact with the `BankAccount`.

## Code Structure

- **BankAccount.cs**: Contains the `BankAccount` class, responsible for managing the account balance and transactions.
- **Program.cs**: The entry point of the application where you can test the `BankAccount` methods.

## Example Output

```plaintext
Deposited $500. New balance: $1500
Withdrawal amount must be greater than zero.
Withdrew $300. New balance: $1200
Insufficient funds for withdrawal.
Withdrawal amount must be greater than zero.
Final balance: $1200
Transactions:
Deposited: $500
Withdrew: $300
