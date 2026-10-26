
using System;

class StudentManagementSystem
{
    // Class-level variables
    int[] marks = { 90, 80, 87, 92, 79 };
    int total = 0;
    double average = 0;

    public void ShowStudentDetails()
    {
        string name = "Spongebob";
        int age = 20;
        string dept = "CSE";

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Department: " + dept);
    }

    public void CalculateTotal()
    {
        total = 0;

        foreach (int mark in marks)
        {
            total += mark;
        }

        Console.WriteLine("Total Marks = " + total);
    }

    public void CalculateAverage()
    {
        average = (double)total / marks.Length;

        Console.WriteLine("Average = " + average);
    }

    public void DisplayGrade()
    {
        if (average >= 90)
            Console.WriteLine("Grade: A");
        else if (average >= 80)
            Console.WriteLine("Grade: B");
        else if (average >= 70)
            Console.WriteLine("Grade: C");
        else if (average >= 60)
            Console.WriteLine("Grade: D");
        else
            Console.WriteLine("Grade: F");
    }
}

class ProgramExecuting
{
    public static void Main(string[] args)
    {
        StudentManagementSystem sms = new StudentManagementSystem();

        Console.WriteLine("Student Details:");
        sms.ShowStudentDetails();

        Console.WriteLine("\nTotal Marks:");
        sms.CalculateTotal();

        Console.WriteLine("\nAverage:");
        sms.CalculateAverage();

        Console.WriteLine("\nGrade:");
        sms.DisplayGrade();
    }
}
