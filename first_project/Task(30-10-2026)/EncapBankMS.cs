using System;

public class EncapBankMS
{
    private double balance = 10000;
    private double amount;

    public void SetAmount(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount should be greater than 0");
            return;
        }

        this.amount = amount;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void Deposit()
    {
        balance += amount;
        Console.WriteLine("Deposit Successful");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount should be greater than 0");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient Balance");
        }
        else
        {
            balance -= amount;
            Console.WriteLine("Withdraw Successful");
        }
    }

    public static void Main(string[] args)
    {
        EncapBankMS bank = new EncapBankMS();

        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");

        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (choice == 1)
        {

            bank.SetAmount(amount);
            bank.Deposit();

        }
        else if (choice == 2)
        {
            bank.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }

        Console.WriteLine($"Current Balance: {bank.GetBalance():F2}");
    }
}