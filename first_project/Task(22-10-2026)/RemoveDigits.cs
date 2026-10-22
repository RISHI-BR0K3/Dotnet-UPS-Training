using System;

public class RemoveDigits
{
    public static void Main(String[] args)
    {
        
        String s = "Madurai123City45";
        String new_s = "";

        foreach(char ch in s)
        {
            if (char.IsLetter(ch))
            {
                new_s += ch;
            }
        }

        System.Console.WriteLine(new_s);

    }
}