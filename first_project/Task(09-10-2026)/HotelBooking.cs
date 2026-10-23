using System;

class HotelBooking
{
    static void Main()
    {
        Console.WriteLine("1. Standard");
        Console.WriteLine("2. Deluxe");
        Console.WriteLine("3. Suite");
        Console.Write("Select room type: ");
        int room = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of days: ");
        int days = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter customer type (Membership/Normal): ");
        string customer = Console.ReadLine().ToLower();

        Console.Write("Do you want food? (yes/no): ");
        string food = Console.ReadLine().ToLower();

        if (room < 1 || room > 3 || days <= 0 ||
            (customer != "membership" && customer != "normal") ||
            (food != "yes" && food != "no"))
        {
            Console.WriteLine("Invalid booking details");
            return;
        }

        int rate = room == 1 ? 1000 : room == 2 ? 2000 : 3000;

        double roomCharge = rate * days;
        double foodCharge = food == "yes" ? 500 * days : 0;
        double discount = customer == "membership" ? roomCharge * 0.05 : 0;

        double total = roomCharge - discount + foodCharge;
        double gst = total * 0.12;
        double bill = total + gst;

        Console.WriteLine("Room Charges: " + roomCharge);
        Console.WriteLine("Food Charges: " + foodCharge);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("GST: " + gst);
        Console.WriteLine("Final Bill: " + bill);
    }
}