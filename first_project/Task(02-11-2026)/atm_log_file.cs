using System;

class Atm_log_file
{

    double balance = 10000;

    static string folderPath = Directory.GetCurrentDirectory();
    static string filePath = Path.Combine(folderPath, "log.txt");

    public void WriteLog(string operation, string status)
    {
        string log = $"{DateTime.Now:dd-MM-yyyy} | " + $"{DateTime.Now:hh : mm tt} | " + $"{operation} | " + $"{status} ";
        File.AppendAllText(filePath, log + Environment.NewLine);
    }

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
        Console.WriteLine("Withdraw Successful");
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: {balance:F2}");
    }

    public static void Main(string[] args)
    {
        Atm_log_file atm = new Atm_log_file();

        string operation = "";
        try
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");

            Console.Write("\nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    operation = "Deposit";

                    Console.Write("Enter deposit amount: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());

                    atm.Deposit(deposit);
                    atm.WriteLog(operation, "Success");
                    break;

                case 2:
                    operation = "Withdraw";

                    Console.Write("Enter withdrawal amount: ");
                    double withdrawal = Convert.ToDouble(Console.ReadLine());

                    atm.Withdraw(withdrawal);
                    atm.WriteLog(operation, "Success");
                    break;

                case 3:
                    operation = "Check Balance";

                    atm.CheckBalance();
                    atm.WriteLog(operation, "Success");
                    break;

                default:
                    operation = "Invalid Choice";
                    Console.WriteLine("Invalid choice!");
                    atm.WriteLog(operation, "Failed");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
            atm.WriteLog(operation, "Failed");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid amount: {ex.Message}");
            atm.WriteLog(operation, "Failed");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Transaction failed: {ex.Message}");
            atm.WriteLog(operation, "Failed");
        }
        finally
        {
            Console.WriteLine("\nTransaction process has ended.");
            atm.CheckBalance();
        }
    }
}
