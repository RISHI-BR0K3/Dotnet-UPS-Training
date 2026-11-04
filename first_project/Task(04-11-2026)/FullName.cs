using System;

public static class NameExtension
{
    public static String FLName(this String FName, String LName)
    {
        return FName + " " + LName;
    }

    public static String FMLName(this String FName, String MName, String LName)
    {
        return FName + " " + MName + " " + LName;
    }

    //without return type
    public static void FullName(this String FName, String LName)
    {
        String fullName = FName + " " + LName;
        Console.WriteLine(fullName);
    }
}

class FullName
{
    static void Main(string[] args)
    {
        String firstName = "Rishi";
        //String middleName = "Ram";
        String lastName = "Ramchand";

        //String fullName = firstName.FMLName(middleName, lastName);
        //Console.WriteLine(fullName);

        firstName.FullName(lastName);
    }
}