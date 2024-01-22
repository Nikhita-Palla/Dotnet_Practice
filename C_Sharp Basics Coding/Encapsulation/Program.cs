using System;

// Class representing a Bank Account with encapsulation
public class BankAccount
{
    // Private fields (data)
    private string accountHolder;
    private double balance;

    // Constructor to initialize the account
    public BankAccount(string accountHolder, double initialBalance)
    {
        this.accountHolder = accountHolder;
        this.balance = initialBalance;
    }

    // Public method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Public method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }
    }

    // Public method to display account information
    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Holder: {accountHolder}");
        Console.WriteLine($"Balance: {balance}");
    }
}

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the BankAccount class
            BankAccount account = new BankAccount("Nikhita Palla", 1000);

            // Accessing the public methods to interact with the object
            account.Deposit(500);
            account.Withdraw(200);

            // Displaying account information
            account.DisplayAccountInfo();
            Console.ReadLine();
        }
    }
}
