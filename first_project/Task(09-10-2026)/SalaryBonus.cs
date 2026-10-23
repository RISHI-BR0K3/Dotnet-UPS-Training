using System;

public class SalaryBonus
{
    public static void Main(String[] args)
    {
        
        double salary = 50000.00;

        Console.Write("Enter the years of experiences: ");
        double experience = Convert.ToDouble(Console.ReadLine());

        if(experience >= 1 && experience < 3)
        {
            salary = (salary * 0.02) + salary;
            Console.WriteLine("Salary After 2% increment: " + salary);
        }

        else if(experience >= 3 && experience < 5)
        {
            salary = (salary * 0.05) + salary;
            Console.WriteLine("Salary after 5% increment: " + salary);
        }

        else if(experience >= 5)
        {
            salary = (salary * 0.10) + salary;
            Console.WriteLine("Salary after 10% increment: " + salary);
        }

        else
        {
            Console.WriteLine("No increment provided");
            Console.WriteLine("Salary: " + salary);
        }

    }
}