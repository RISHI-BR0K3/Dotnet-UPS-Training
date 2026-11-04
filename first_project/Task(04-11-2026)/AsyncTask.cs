using System;
using System.Threading.Tasks;

class AsyncTask
{
    static async Task GetStudentDetails()
    {
        Console.WriteLine("Requesting student details from database...");

        await Task.Delay(5000);

        Console.WriteLine("Student details received!");
    }

    static void HandleEnquiry()
    {
        Console.WriteLine("Receptionist is handling another student enquiry");
    }

    static void Main()
    {
        Console.WriteLine("Receptionist started registration");

        Task task = GetStudentDetails();

        HandleEnquiry();

        Console.WriteLine("Waiting for database response...");

        task.GetAwaiter().GetResult();

        Console.WriteLine("Registration completed");
    }
}