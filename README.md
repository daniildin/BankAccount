# Bank Account Unit Tests

This repository contains unit tests for the `BankAccount` class to ensure the proper functioning of the methods like deposit, withdrawal, and transaction recording.

## Tests Overview

### 1. Constructor Test
Verifies that a new `BankAccount` instance initializes correctly with the correct customer name, initial balance, and an empty transaction list.

### 2. Deposit Method Tests
- **Positive Deposit**: Ensures depositing a valid positive amount increases the balance as expected.
- **Record Transaction on Deposit**: Confirms that a deposit transaction is recorded correctly in the transaction list.
- **Invalid Deposit Amount**: Tests the handling of invalid deposit amounts, such as negative numbers or zero.

### 3. Withdraw Method Tests
- **Successful Withdrawal**: Verifies that withdrawing a valid amount correctly decreases the account balance.
- **Record Transaction on Withdrawal**: Ensures that a withdrawal transaction is properly recorded in the transaction list.
- **Withdrawal Exceeds Balance**: Tests the behavior when the withdrawal amount exceeds the available balance, ensuring proper error handling.
- **Invalid Withdrawal Amount**: Checks the handling of invalid withdrawal amounts like negative numbers or zero.

### 4. Transaction Recording Tests
- **Correctness of Transaction Records**: Verifies that the transaction list accurately reflects all deposits and withdrawals, including the correct amounts and order.
- **Transaction Timestamps**: If timestamps are included in transactions, verifies that they are logical (e.g., not in the future).

### 5. Account Balance Tests
- **Accuracy of Balance**: After a sequence of deposits and withdrawals, ensures the balance matches the expected amount.
- **Initial Balance Test**: Verifies that the initial balance is correctly set when the account is created.


![image](https://github.com/user-attachments/assets/3019964c-4f0b-4052-815c-4fc8b2db7d3d)
