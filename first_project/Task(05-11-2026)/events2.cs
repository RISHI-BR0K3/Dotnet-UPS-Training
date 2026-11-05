using System;

// Delegate
public delegate void OrderHandler(string productName);

// Publisher
class Shopping
{
    public event OrderHandler OrderPlaced;

    public void PlaceOrder(string product)
    {
        Console.WriteLine("Order placed: " + product);

        // Raise event
        OrderPlaced?.Invoke(product);
    }
}

// Subscriber 1
class Customer
{
    public static void SendConfirmation(string product)
    {
        Console.WriteLine(
          "Customer: Order confirmed for " + product);
    }
}

// Subscriber 2
class Warehouse
{
    public static void PackProduct(string product)
    {
        Console.WriteLine(
          "Warehouse: Packing " + product);
    }
}

// Subscriber 3
class Delivery
{
    public static void AssignDelivery(string product)
    {
        Console.WriteLine(
          "Delivery: Delivery assigned for " + product);
    }
}

// Main
class Events2
{
    static void Main()
    {
        Shopping shop = new Shopping();

        // Subscribe
        shop.OrderPlaced += Customer.SendConfirmation;
        shop.OrderPlaced += Warehouse.PackProduct;
        shop.OrderPlaced += Delivery.AssignDelivery;

        // Place order
        shop.PlaceOrder("Laptop");
        shop.PlaceOrder("Glass");
    }
}
