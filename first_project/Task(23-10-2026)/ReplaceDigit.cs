using System;

public class ReplaceDigit
{
    public static void Main(String[] args)
    {
        String s = "abc123xyz45";

        foreach (char ch in s)
        {
            if (char.IsDigit(ch))
            {
                s = s.Replace(ch, '*');
            }
        }

        Console.WriteLine(s);
    }
}
