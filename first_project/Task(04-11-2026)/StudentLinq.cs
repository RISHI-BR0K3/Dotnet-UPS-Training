using System;
using System.Collections.Generic;
using System.Linq;

// Student Class
class Students
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";
    public int Marks { get; set; }
}

class StudentDetails
{
    static void Main()
    {
        // Student Collection
        List<Students> students = new List<Students>
        {
        new Students { Id = 1, Name = "Arun", Department = "CSE", Marks = 85 },
        new Students { Id = 2, Name = "Priya", Department = "IT", Marks = 29 },
        new Students { Id = 3, Name = "Kumar", Department = "CSE", Marks = 45 },
        new Students { Id = 4, Name = "Divya", Department = "ECE", Marks = 95 },
        new Students { Id = 5, Name = "Ravi", Department = "IT", Marks = 35 }
        };

        //marks below 30
        Console.WriteLine("Marks Below 30:");
        var result1 = students.Where(s => s.Marks < 30);
        foreach (var s in result1)
        {
            Console.WriteLine(s.Name);
        }
        Console.WriteLine();

        //marks above 80
        Console.WriteLine("Marks Above 80:");
        var result2 = students.Where(s => s.Marks > 80);
        foreach (var s in result2)
        {
            Console.WriteLine(s.Name + " - " + s.Marks);
        }
        Console.WriteLine();

        //marks below 30 with the Name and Marks
        Console.WriteLine("Marks Below 30:");
        var result3 = students.Where(s => s.Marks < 30);
        foreach (var s in result3)
        {
            Console.WriteLine(s.Name + " - " + s.Marks);
        }
        Console.WriteLine();


        //Group by department and print the names and dept
        var result4 = students.GroupBy(s => s.Department);

        foreach (var group in result4)
        {
            Console.WriteLine("\nDepartment: " + group.Key);

            foreach (var s in group)
            {
                Console.WriteLine(s.Name + " - " + s.Marks);
            }
        }


        //Group by department and print who has mark above 80
        var result5 = students.GroupBy(s => s.Department);

        foreach (var group in result5)
        {
            Console.WriteLine("\nDepartment with score above 80: " + group.Key);

            foreach (var s in group.Where(s => s.Marks > 80))
            {
                Console.WriteLine(s.Name + " - " + s.Marks);
            }
        }


        //max score
        Console.WriteLine("\nMax score");
        int result6 = students.Max(s => s.Marks);
        Console.WriteLine("Highest Marks: " + result6);

        //Department max mark
        Console.WriteLine("\nDepartment wise max mark");
        var result7 = students.GroupBy(s => s.Department);

        foreach (var group in result7)
        {
            Console.WriteLine("Department: " + group.Key);
            Console.WriteLine("Maximum Mark: " + group.Max(s => s.Marks));
        }

        //Department min mark
        Console.WriteLine("\nDepartment wise min mark");
        var result8 = students.GroupBy(s => s.Department);

        foreach (var group in result8)
        {
            Console.WriteLine("Department: " + group.Key);
            Console.WriteLine("Minimum Mark: " + group.Min(s => s.Marks));
        }

        //Department count mark
        Console.WriteLine("\nDepartment count");
        var result9 = students.GroupBy(s => s.Department);

        foreach (var group in result9)
        {
            Console.WriteLine("Department: " + group.Key);
            Console.WriteLine("Count: " + group.Count());
        }

    }
}