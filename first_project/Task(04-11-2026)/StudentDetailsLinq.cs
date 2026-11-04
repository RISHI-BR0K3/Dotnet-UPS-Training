using System;
using System.Collections.Generic;
using System.Linq;

// Student Class
class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";
    public int Marks { get; set; }
}

class StudentDetailsLinq
{
    static void Main()
    {
        // Student Collection
        List<Student> students = new List<Student>
    {
      new Student { Id = 1, Name = "Arun", Department = "CSE", Marks = 85 },
      new Student { Id = 2, Name = "Priya", Department = "IT", Marks = 90 },
      new Student { Id = 3, Name = "Kumar", Department = "CSE", Marks = 45 },
      new Student { Id = 4, Name = "Divya", Department = "ECE", Marks = 75 },
      new Student { Id = 5, Name = "Ravi", Department = "IT", Marks = 35 }
    };

        // 1. WHERE - Filter students above 60
        Console.WriteLine("\n1. WHERE - Marks Above 60");

        var result1 = students.Where(s => s.Marks > 60);

        foreach (var s in result1)
        {
            Console.WriteLine(s.Name + " - " + s.Marks);
        }

        // 2. SELECT - Get only student names
        Console.WriteLine("\n2. SELECT - Student Names");

        var result2 = students.Select(s => s.Name);

        foreach (var name in result2)
        {
            Console.WriteLine(name);
        }

        // 3. ORDERBY - Ascending order
        Console.WriteLine("\n3. ORDERBY - Lowest to Highest");

        var result3 = students.OrderBy(s => s.Marks);

        foreach (var s in result3)
        {
            Console.WriteLine(s.Name + " - " + s.Marks);
        }

        // 4. ORDERBYDESCENDING - Highest to Lowest
        Console.WriteLine("\n4. ORDERBYDESCENDING");

        var result4 = students.OrderByDescending(s => s.Marks);

        foreach (var s in result4)
        {
            Console.WriteLine(s.Name + " - " + s.Marks);
        }



        // 5. FIRST - Get first student with marks above 80
        Console.WriteLine("\n5. FIRST");

        var result5 = students.First(s => s.Marks > 80);

        Console.WriteLine(result5.Name);

        // 6. FIRSTORDEFAULT - Search student by name
        Console.WriteLine("\n6. FIRSTORDEFAULT");

        var result6 = students.FirstOrDefault(s => s.Name == "Sam");

        if (result6 != null)
            Console.WriteLine(result6.Name);
        else
            Console.WriteLine("Student not found");

        // 7. SINGLE - Find student using unique ID
        Console.WriteLine("\n7. SINGLE");

        var result7 = students.Single(s => s.Id == 3);

        Console.WriteLine(result7.Name);

        // 8. COUNT - Total number of students
        Console.WriteLine("\n8. COUNT");

        int result8 = students.Count();

        Console.WriteLine("Total Students: " + result8);

        // 9. ANY - Check if any student scored above 90
        Console.WriteLine("\n9. ANY");

        bool result9 = students.Any(s => s.Marks > 90);

        Console.WriteLine(result9);

        // 10. ALL - Check if all students scored above 30
        Console.WriteLine("\n10. ALL");

        bool result10 = students.All(s => s.Marks > 30);

        Console.WriteLine(result10);

        // 11. SUM - Total marks
        Console.WriteLine("\n11. SUM");

        int result11 = students.Sum(s => s.Marks);

        Console.WriteLine("Total Marks: " + result11);

        // 12. MAX - Highest marks
        Console.WriteLine("\n12. MAX");

        int result12 = students.Max(s => s.Marks);

        Console.WriteLine("Highest Marks: " + result12);

        // 13. MIN - Lowest marks
        Console.WriteLine("\n13. MIN");

        int result13 = students.Min(s => s.Marks);

        Console.WriteLine("Lowest Marks: " + result13);

        // 14. AVERAGE - Average marks
        Console.WriteLine("\n14. AVERAGE");

        double result14 = students.Average(s => s.Marks);

        Console.WriteLine("Average Marks: " + result14);

        // 15. GROUPBY - Group students by department
        Console.WriteLine("\n15. GROUPBY");

        var result15 = students.GroupBy(s => s.Department);

        foreach (var group in result15)
        {
            Console.WriteLine("\nDepartment: " + group.Key);

            foreach (var s in group)
            {
                Console.WriteLine(s.Name + " - " + s.Marks);
            }
        }



        // 16. TOLIST - Convert filtered result into List
        Console.WriteLine("\n16. TOLIST");

        List<Student> result16 = students
          .Where(s => s.Marks >= 50)
          .ToList();

        foreach (var s in result16)
        {
            Console.WriteLine(s.Name + " - " + s.Marks);
        }
    }
}