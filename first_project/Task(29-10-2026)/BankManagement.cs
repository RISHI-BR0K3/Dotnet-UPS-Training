using System;

public class BankManagement
{
    double balance = 10000;

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount should be greater than 0");
        }
        balance += amount;
        Console.WriteLine("Deposit Successful");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount should be greater than 0");
        }

        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient Balance");
        }

        balance -= amount;
        Console.WriteLine("Withdraw successful");
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: {balance:F2}");
    }

    public static void Main(String[] args)
    {
        BankManagement bank = new BankManagement();

        try
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter deposit amount: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    bank.Deposit(deposit);
                    break;

                case 2:
                    Console.Write("Enter withdrawal amount: ");
                    double withdrawal = Convert.ToDouble(Console.ReadLine());
                    bank.Withdraw(withdrawal);
                    break;

                case 3:
                    bank.CheckBalance();
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid amount: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Transaction failed: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nTransaction process has ended.");
            bank.CheckBalance();
            Console.WriteLine("Memory Cleaned");
        }
    }
}
