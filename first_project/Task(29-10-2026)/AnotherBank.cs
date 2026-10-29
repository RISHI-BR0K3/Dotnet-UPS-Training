using System;

class InvalidAmountException : Exception
{
    public InvalidAmountException(String message) : base(message)
    {
        
    }
}

public class AnotherBank
{
    
    static double balance = 10000;
    public static void Deposit(double amount)
    {
        if(amount < 0)
        {
            throw new InvalidAmountException("Amount should be greater than 0");
        }
        balance += amount;
        Console.WriteLine("Deposit Successful");
    }

    public static void Withdraw(double amount)
    {
        if(amount < 0)
        {
            throw new InvalidAmountException("Amount should be greater than 0");
        }
        balance -= amount;
        Console.WriteLine("Withdraw Successful");
    }

    public static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");


            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter deposit amount: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    Deposit(deposit);
                    break;

                case 2:
                    Console.Write("Enter withdrawal amount: ");
                    double withdrawal = Convert.ToDouble(Console.ReadLine());
                    Withdraw(withdrawal);
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
        catch(InvalidAmountException ex)
        {
            Console.WriteLine($"Invalid Amount: {ex.Message}");
        }
        finally
        {
            Console.WriteLine($"Balance: {balance:F2}");
            Console.WriteLine("Process ended");
        }
    }

}