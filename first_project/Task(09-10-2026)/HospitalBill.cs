using System;

class HospitalBill
{
    static void Main()
    {
        Console.WriteLine("1. General Ward - 500");
        Console.WriteLine("2. Private Room - 2000");
        Console.WriteLine("3. ICU - 5000");
        Console.Write("Select room type: ");
        int room = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of days: ");
        int days = Convert.ToInt32(Console.ReadLine());

        Console.Write("Are you a senior citizen? (yes/no): ");
        string senior = Console.ReadLine().ToLower();

        if (room < 1 || room > 3 || days <= 0 ||
            (senior != "yes" && senior != "no"))
        {
            Console.WriteLine("Invalid details");
            return;
        }

        int rate = room == 1 ? 500 : room == 2 ? 2000 : 5000;
        double roomCharge = rate * days;
        double consultation = 800;
        double total = roomCharge + consultation;
        double discount = senior == "yes" ? total * 0.05 : 0;
        double finalAmount = total - discount;

        Console.WriteLine("Room Charges: " + roomCharge);
        Console.WriteLine("Consultation Charges: " + consultation);
        Console.WriteLine("Senior Citizen Discount: " + discount);
        Console.WriteLine("Final Amount Payable: " + finalAmount);
    }
}