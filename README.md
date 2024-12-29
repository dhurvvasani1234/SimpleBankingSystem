# SimpleBankingSystem
This project appears to be a simple banking system simulation implemented in C# WB level_2_lab_4

# SimpleBankingSystem

## Overview
SimpleBankingSystem is a console-based banking application written in C#. This project demonstrates object-oriented programming (OOP) concepts and simulates basic banking operations such as account creation, deposits, withdrawals, and calculating account balances over time with monthly fees, interest, and deposits. It is designed as a learning tool for understanding C# fundamentals, class design, and financial calculations.

## Features
- **Account Management**:
  - Create bank accounts with a unique account number, owner name, initial deposit, and monthly deposit amount.
  - Validate inputs to ensure compliance with minimum requirements (e.g., minimum initial balance and monthly deposit).

- **Banking Operations**:
  - Simulate monthly transactions, including:
    - Deduction of a monthly fee.
    - Addition of interest on the current balance.
    - Addition of monthly deposits.
  - Display account details and balance after a user-defined number of months.

- **User Interaction**:
  - Console-based interface for collecting user inputs and displaying results.
  - Error handling for invalid inputs and insufficient balance during withdrawals.

## Technologies Used
- **Programming Language**: C#
- **Framework**: .NET Framework
- **Development Environment**: Visual Studio

## Requirements
- .NET Framework (version 4.7.2 or later)
- Visual Studio (or any C# compatible IDE)

## Installation
1. Clone this repository:
   ```bash
   git clone https://github.com/username/SimpleBankingSystem.git
   ```
2. Open the project in Visual Studio.
3. Build the solution to restore dependencies.
4. Run the project from Visual Studio.

## Usage
1. Start the program by running the `Bank.cs` file.
2. Enter the number of months to simulate deposits.
3. Enter customer details for each account:
   - Customer name
   - Initial deposit amount (minimum $1,000)
   - Monthly deposit amount (minimum $50)
4. Repeat the process for as many accounts as needed.
5. Press Enter when no more customer details need to be added.
6. The program will simulate monthly transactions and display the updated account balance for each customer after the specified number of months.

## Code Structure
- **Account.cs**:
  - Defines the `Account` class with properties and methods for managing account details and performing transactions.
  - Includes constructors for different initialization scenarios.

- **Bank.cs**:
  - The main program that manages user interactions and processes account transactions.
  - Contains logic for creating accounts, simulating monthly updates, and displaying results.

## Example Output
```text
Enter number of months to deposit: 6

Enter Customer's Name: John Doe
Enter John's Initial Deposit Amount (minimum $1,000.00): 1500
Enter John's Monthly Deposit Amount (minimum $50.00): 100

After 6 month(s), John Doe's account (#98234), has a balance of: $1651.47
Press Enter to complete
```

## Learning Objectives
- Understand OOP principles such as:
  - Encapsulation
  - Static members
  - Constructor overloading
- Use collections (e.g., `List<T>`) for managing multiple objects.
- Apply basic financial computations involving fees, interest, and deposits.
- Build interactive console applications with user input and error handling.

## Future Enhancements
- Add a graphical user interface (GUI).
- Implement account types (e.g., Savings, Checking) with unique rules.
- Enable persistent data storage using a database or file system.
- Add support for multi-threading to handle concurrent account operations.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Contributors
- [Your Name](https://github.com/username)

Feel free to contribute by submitting issues or pull requests!

