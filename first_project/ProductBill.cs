using System;

public class ProductBill
{
    public static void Main(String[] args)
    {
        
        Console.Write("Enter the prodcut name: ");
        String productName = Console.ReadLine();

        Console.Write("Enter the quantity of the product: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the price of the product: ");
        double price = Convert.ToDouble(Console.ReadLine());

        double GST = 0.18;

        double totalPrice = (quantity * price);
        double totalPriceWithGST = (totalPrice * GST) + totalPrice;

        if(totalPrice > 5000)
        {
            Console.WriteLine("Product: " + productName);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Total Price: " + totalPriceWithGST);
            Console.WriteLine("Price After Discount: " + (totalPriceWithGST - (totalPriceWithGST*0.05)));

        }

    }
}