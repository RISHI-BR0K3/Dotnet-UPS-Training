using System;

public class ArrayArmstrong
{
    public static void Main(String[] args)
    {
        
        int[] array = new int[5];


        Console.WriteLine("Enter 5 numbers to check armstrong");
        for(int i=0; i<array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int i=0; i<array.Length; i++)
        {
            int temp = array[i];
            int lastDigit;
            int sum = 0;
            int numberLength = array[i].ToString().Length;

            while(array[i] > 0)
            {
                lastDigit = array[i] % 10;
                sum += (int)Math.Pow(lastDigit,numberLength);
                array[i] = array[i]/10;
            }

            if(sum == temp)
            {
                Console.WriteLine(sum + " is a Armstrong number");
            }
            else
            {
                Console.WriteLine(temp + " is not a Armstrong Number");
            }


        }

    }
}