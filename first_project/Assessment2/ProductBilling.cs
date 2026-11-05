using System;

class Product
{
    public int productID;
    public String productName = "";
    public double productPrice;

    public void DisplayProductDetails(String productName, double productPrice)
    {
        Console.WriteLine($"Product: {productName}");
        Console.WriteLine($"Price: {productPrice}");
    }
}

class BillingProduct : Product
{
    public double GST = 0.18;
    public int warrantyYears;

    public double CalculateGST()
    {
        return productPrice * 0.18;
    }

    public double CalculateFinalPrice()
    {
        return productPrice + CalculateGST();
    }

    public void DisplayInvoice()
    {
        DisplayProductDetails(productName, productPrice);

        Console.WriteLine("GST: " + CalculateGST());
        Console.WriteLine("Warranty: " + warrantyYears + " Years");
        Console.WriteLine("Final Price: " + CalculateFinalPrice());
    }
}

class ProductBilling
{
    static void Main()
    {
        BillingProduct bill = new BillingProduct();

        bill.productID = 101;
        bill.productName = "Laptop";
        bill.productPrice = 50000;
        bill.warrantyYears = 2;

        bill.DisplayInvoice();
    }
}