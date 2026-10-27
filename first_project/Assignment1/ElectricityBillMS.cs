using System;

class ElectricityBillManagementSystem
{
    static double CalculateBill(int id, string name, int units)
    {
        double energyCharge = 0;
        double fixedCharge = 100;
        double surcharge = 0;

        //energy charge
        if (units <= 100)
        {
            energyCharge = units * 1.5;
        }
        else if (units <= 200)
        {
            energyCharge = (100 * 1.5) + (units - 100) * 2.5;
        }
        else if (units <= 300)
        {
            energyCharge = (100 * 1.5) + (100 * 2.5) + (units - 200) * 4;
        }
        else
        {
            energyCharge = (100 * 1.5) + (100 * 2.5) + (100 * 4) + (units - 300) * 5;
        }

        double bill = energyCharge + fixedCharge;

        //surcharge
        if (bill > 1000)
            surcharge = bill * 0.05;

        double totalBill = bill + surcharge;

        //category
        string category;

        if (totalBill <= 500)
            category = "Low Consumption";
        else if (totalBill <= 1500)
            category = "Medium Consumption";
        else
            category = "High Consumption";

        //Displaying bil
        Console.WriteLine("\n     Electricity Bill     ");
        Console.WriteLine($"Customer ID: {id}");
        Console.WriteLine($"Customer Name: {name}");
        Console.WriteLine($"Units Consumed: {units}");
        Console.WriteLine($"Energy Charges: Rs. {energyCharge}.00");
        Console.WriteLine($"Fixed Charges: Rs. {fixedCharge}.00");
        Console.WriteLine($"Surcharge: Rs. {surcharge}.00");
        Console.WriteLine($"Total Bill: Rs. {totalBill}.00");
        Console.WriteLine($"Category: {category}");

        return totalBill;
    }

    static void Main()
    {
        int customerCount = 0;
        double totalRevenue = 0;
        int numberOfCustomers;

        Console.Write("Enter number of customers: ");
        numberOfCustomers = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numberOfCustomers; i++)
        {
            Console.WriteLine($"\nEnter details for Customer {i}");

            Console.Write("Enter Customer ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Units Consumed: ");
            int units = Convert.ToInt32(Console.ReadLine());

            totalRevenue += CalculateBill(id, name, units);
            customerCount++;
        }

        Console.WriteLine("\n     Final Summary     ");
        Console.WriteLine($"Customers Processed: {customerCount}");
        Console.WriteLine($"Total Revenue: Rs. {totalRevenue}.00");
    }
}
