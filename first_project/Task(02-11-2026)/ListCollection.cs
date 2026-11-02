using System;

class ListCollection
{
    public static void Main(String[] args)
    {

        List<int> numbers = new List<int>();

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter number to add in list: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            numbers.Add(userInput);
        }

        foreach (var i in numbers)
        {
            Console.Write($"{i} ");
        }

    }
}