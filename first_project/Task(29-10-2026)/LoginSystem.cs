using System;

class TooManyAttempts : Exception
{
    public TooManyAttempts(String Message) : base(Message)
    {

    }
}

public class LoginSystem
{
    static String username = "admin";
    static String password = "12345";

    public static void Main(String[] args)
    {
        try
        {
            int attempts = 0;
            string? userName;
            string? passWord;
            Console.WriteLine("Enter your username and password:");
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter username: ");
                userName = Console.ReadLine();

                Console.Write("Enter passWord: ");
                passWord = Console.ReadLine();

                if (userName == username && passWord == password)
                {
                    Console.WriteLine("Login Successful");
                    break;
                }

                attempts++;
                Console.WriteLine("Login failed. Try again.");
                if (attempts < 3)
                {
                    Console.WriteLine($"{3 - attempts} attempts left");
                    Console.WriteLine();
                }
            }
            if(attempts == 3)
            {
                throw new TooManyAttempts("Too many attempts");
            }
        }
        catch(TooManyAttempts ex)
        {
            Console.WriteLine($"Login failed: {ex.Message}");
        }
    }
}