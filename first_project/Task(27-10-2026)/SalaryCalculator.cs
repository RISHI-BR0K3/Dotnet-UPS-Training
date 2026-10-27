using System;

class SalaryCalculator
{
    
    public void CalculateSalary(int basicSalary)
    {
        System.Console.WriteLine($"The basic salary is {basicSalary}");
    }

    public void CalculateSalary(int basicSalary, int allowance)
    {
        System.Console.WriteLine($"The salary with allowance is {basicSalary + allowance}");
    }

    public void CalculateSalary(int basicSalary, int allowance, int bonus)
    {
        System.Console.WriteLine($"The salary with basicsalary, allowance and bonus is {basicSalary + allowance + bonus}");
    }

}

class ProgramExecu
{
    
    public static void Main(String[] args)
    {
        
        SalaryCalculator SC = new SalaryCalculator();

        SC.CalculateSalary(25000);

        SC.CalculateSalary(25000, 3000);

        SC.CalculateSalary(25000, 3000, 2800);

    }

}