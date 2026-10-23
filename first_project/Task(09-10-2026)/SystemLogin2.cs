using System;

public class SystemLogin2
{
    public static void Main(String[] args)
    {
        Console.Write("Enter username: ");
        String userName = Console.ReadLine();

        Console.Write("Enter password: ");
        String password = Console.ReadLine();

        if(userName == "Rishi" && password == "12345")
        {
            Console.WriteLine("You have logged in successfully");
        }
        else
        {
            Console.WriteLine("Enter the correct user details");
        }
    }
}