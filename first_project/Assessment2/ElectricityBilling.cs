using System;

class ElectricityBill
{
    public virtual double CalculateBill(int units)
    {
        return 0;
    }
}

class DomesticConnection : ElectricityBill
{
    public override double CalculateBill(int units)
    {
        if (units < 0)
        {
            Console.WriteLine("Invalid units");
            return 0;
        }

        if (units <= 100)
            return units * 2;
        else
            return (100 * 2) + (units - 100) * 5;
    }
}

class CommercialConnection : ElectricityBill
{
    public override double CalculateBill(int units)
    {
        if (units < 0)
        {
            Console.WriteLine("Invalid units");
            return 0;
        }

        if (units <= 100)
            return units * 5;
        else
            return (100 * 5) + (units - 100) * 8;
    }
}

class IndustrialConnection : ElectricityBill
{
    public override double CalculateBill(int units)
    {
        if (units < 0)
        {
            Console.WriteLine("Invalid units");
            return 0;
        }
        else
        {
            return units * 10;
        }
    }
}

class BillInvoice
{
    public static void Main(string[] args)
    {
        int fixedCharge = 50;

        Console.Write("Enter which type of current (1-Domestic, 2-Commercial, 3-Industrial): ");
        int currentType = Convert.ToInt32(Console.ReadLine());

        ElectricityBill bill;

        switch (currentType)
        {
            case 1:
                bill = new DomesticConnection();
                break;

            case 2:
                bill = new CommercialConnection();
                break;

            case 3:
                bill = new IndustrialConnection();
                break;

            default:
                Console.WriteLine("Invalid current type");
                return;
        }

        Console.Write("Enter units consumed: ");
        int unitsConsumed = Convert.ToInt32(Console.ReadLine());

        if (unitsConsumed < 0)
        {
            Console.WriteLine("Invalid units");
            return;
        }

        double electricityCharge = bill.CalculateBill(unitsConsumed);
        double totalBill = electricityCharge + fixedCharge;

        string connectionType;

        if (currentType == 1)
            connectionType = "Domestic";
        else if (currentType == 2)
            connectionType = "Commercial";
        else
            connectionType = "Industrial";

        Console.WriteLine();

        Console.WriteLine(connectionType + " Units: " + unitsConsumed);
        Console.WriteLine("Electricity Charge: " + electricityCharge);
        Console.WriteLine("Fixed Charge: " + fixedCharge);
        Console.WriteLine("Total Bill: " + totalBill);
    }
}

