using System;

class VehicleRent
{
    static void Main()
    {
        Console.WriteLine("1. Car - 1000/day");
        Console.WriteLine("2. Bike - 300/day");
        Console.Write("Select vehicle: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Do you have a driving licence? (Yes/No): ");
        string licence = Console.ReadLine().ToLower();

        Console.Write("Enter rental days: ");
        int days = Convert.ToInt32(Console.ReadLine());

        if (choice < 1 || choice > 2 || days <= 0 ||
            age <= 20 || age > 45 ||
            (licence != "yes" && licence != "no"))
        {
            Console.WriteLine("Invalid details");
            return;
        }

        if (licence != "yes")
        {
            Console.WriteLine("You are not eligible for rental");
            return;
        }

        int rate = choice == 1 ? 1000 : 300;
        double total = rate * days;

        Console.WriteLine("Rental Days: " + days);
        Console.WriteLine("Rent Per Day: " + rate);
        Console.WriteLine("Final Rental Amount: " + total);
    }
}