using System;
using System.IO;

class ProductInventoryManagement
{
    static void Main(string[] args)
    {
        String path = "products.txt";

        try
        {
            Console.Write("How many products to add: ");
            int count = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write("Product name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Quantity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    writer.WriteLine(name + "," + price + "," + quantity);
                }

            }

            string[] lines = File.ReadAllLines(path);
            double totalInventory = 0;

            Console.WriteLine("\nAll Products:");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                double price = Convert.ToDouble(parts[1]);
                int quantity = Convert.ToInt32(parts[2]);

                Console.WriteLine(parts[0] + " | Price: " + price + " | Quantity: " + quantity);
                totalInventory += price * quantity;
            }

            Console.Write("\nEnter product name to search: ");
            string search = Console.ReadLine();
            bool found = false;

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts[0].ToLower() == search.ToLower())
                {
                    double price = Convert.ToDouble(parts[1]);
                    int quantity = Convert.ToInt32(parts[2]);

                    Console.WriteLine("Quantity: " + quantity);
                    Console.WriteLine("Value of this product: " + (price * quantity));
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Product not found.");
            }

            Console.WriteLine("Total inventory value: " + totalInventory);


        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid numbers for price and quantity.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("the file not found.");
        }
    }
}