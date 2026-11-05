
using System;

class Patient
{
    private int patientId;
    private string name;
    private int age;
    private double temperature;
    private double consultationFee;

    // Read-only property
    public int PatientId
    {
        get { return patientId; }
    }

    // Name property
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Age property with validation
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Age cannot be negative.");

            age = value;
        }
    }

    // Temperature property with validation
    public double Temperature
    {
        get { return temperature; }
        set
        {
            if (value < 30 || value > 45)
                throw new ArgumentException(
                    "Temperature must be between 30 and 45.");

            temperature = value;
        }
    }

    // Consultation fee property
    public double ConsultationFee
    {
        get { return consultationFee; }
        set
        {
            if (value < 0)
                throw new ArgumentException(
                    "Consultation fee cannot be negative.");

            consultationFee = value;
        }
    }

    // Constructor
    public Patient(int id, string name, int age,
                  double temperature, double consultationFee)
    {
        patientId = id;
        Name = name;
        Age = age;
        Temperature = temperature;
        ConsultationFee = consultationFee;
    }

    // Check temperature
    public void CheckTemperature()
    {
        if (Temperature > 37.5)
            Console.WriteLine("Status: High Temperature");
        else
            Console.WriteLine("Status: Normal Temperature");
    }

    // Calculate total bill
    public void CalculateTotalBill(double medicineCharge)
    {
        if (medicineCharge < 0)
        {
            throw new ArgumentException(
                "Medicine charge cannot be negative.");
        }

        double totalBill = ConsultationFee + medicineCharge;

        Console.WriteLine($"Medicine Charge: {medicineCharge}");
        Console.WriteLine($"Total Bill: {totalBill}");
    }

    // Display patient details
    public void DisplayPatientDetails()
    {
        Console.WriteLine("\n--- Patient Details ---");
        Console.WriteLine($"Patient ID: {PatientId}");
        Console.WriteLine($"Patient Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Temperature: {Temperature}°C");

        CheckTemperature();

        Console.WriteLine(
            $"Consultation Fee: {ConsultationFee}");
    }
}

class HospitalManagement
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Patient ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Temperature: ");
            double temperature =
                Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Consultation Fee: ");
            double consultationFee =
                Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Medicine Charge: ");
            double medicineCharge =
                Convert.ToDouble(Console.ReadLine());

            Patient p = new Patient(
                id, name, age, temperature, consultationFee);

            p.DisplayPatientDetails();

            p.CalculateTotalBill(medicineCharge);
        }
        catch (Exception)
        {
            Console.WriteLine(
                "Invalid input! Please enter valid values.");
        }
    }
}
