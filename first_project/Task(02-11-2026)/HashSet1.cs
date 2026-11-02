using System;

class HashSet1
{
    public static void Main(String[] args)
    {

        HashSet<int> numbers = new HashSet<int>();

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