using System;

public class RemoveSpecialChar
{
    public static void Main(String[] args)
    {
        
        String s = "Hello@123#World!";
        String new_s = "";

        foreach(char ch in s)
        {
            if (char.IsLetter(ch))
            {
                new_s += ch;
            }
            else if (char.IsDigit(ch))
            {
                new_s += ch;
            }
        }

        System.Console.WriteLine(new_s);

    }
}