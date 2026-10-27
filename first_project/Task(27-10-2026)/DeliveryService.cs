using System;

class DeliveryService
{
    public double CalculateDeliveryCharge(double distance)
    {
        return distance * 10;
    }

 
    public double CalculateDeliveryCharge(double distance, double weight)
    {
        return (distance * 10) + (weight * 5);
    }

 
    public double CalculateDeliveryCharge(double distance, double weight, bool isExpress)
    {
        double charge = (distance * 10) + (weight * 5);

        if (isExpress)
        {
            charge += 100;
        }

        return charge;
    }

    static void Main()
    {
        DeliveryService ds = new DeliveryService();

        Console.WriteLine("Delivery charge (distance only): Rs. " +
            ds.CalculateDeliveryCharge(10));

        Console.WriteLine("Delivery charge (distance and weight): Rs. " +
            ds.CalculateDeliveryCharge(10, 5));

        Console.WriteLine("Delivery charge (express delivery): Rs. " +
            ds.CalculateDeliveryCharge(10, 5, true));
    }
}
