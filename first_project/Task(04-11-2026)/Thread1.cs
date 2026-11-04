using System;
using System.Threading;

class ThreadOne
{
    static void Registration()
    {
        Console.WriteLine("Staff 1: Student Registration Started");

        Thread.Sleep(3000);

        Console.WriteLine("Staff 1: Registration Completed");
    }

    static void FeeCollection()
    {
        Console.WriteLine("Staff 2: Fee Collection Started");

        Thread.Sleep(2000);

        Console.WriteLine("Staff 2: Fee Collection Completed");
    }

    static void StudentEnquiry()
    {
        Console.WriteLine("Staff 3: Student Enquiry Started");

        Thread.Sleep(1000);

        Console.WriteLine("Staff 3: Student Enquiry Completed");
    }

    static void Main()
    {
        Thread t1 = new Thread(Registration);
        Thread t2 = new Thread(FeeCollection);
        Thread t3 = new Thread(StudentEnquiry);

        t1.Start();
        t2.Start();
        t3.Start();

        Console.WriteLine("Main thread is also running");
    }
}

