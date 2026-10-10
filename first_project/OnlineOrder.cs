using System;

class OnlineOrder
{
    static void Main()
    {
        Console.WriteLine("1. Watch - 5000");
        Console.WriteLine("2. Stationary - 3000");
        Console.WriteLine("3. Dress - 8000");
        Console.Write("Select product: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter coupon code: ");
        string coupon = Console.ReadLine().ToLower();

        Console.Write("Enter payment method (Gpay/PhonePe): ");
        string payment = Console.ReadLine().ToLower();

        if (choice < 1 || choice > 3 || quantity <= 0)
        {
            Console.WriteLine("Invalid order details");
            return;
        }

        if (payment != "gpay" && payment != "phonepe")
        {
            Console.WriteLine("Invalid payment method");
            return;
        }

        int price = choice == 1 ? 5000 : choice == 2 ? 3000 : 8000;
        string validCoupon = choice == 1 ? "wat001" : choice == 2 ? "sat002" : "dre003";

        double total = price * quantity;
        double discount = 0;

        if (quantity >= 5 && coupon == validCoupon)
        {
            discount = total * 0.15;
        }

        double shipping = 350;
        double finalAmount = total - discount + shipping;

        Console.WriteLine("Order Value: " + total);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Shipping Charges: " + shipping);
        Console.WriteLine("Payment Method: " + payment);
        Console.WriteLine("Final Amount: " + finalAmount);
    }
}