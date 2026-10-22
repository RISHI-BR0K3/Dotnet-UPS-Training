using System;

public class ConvertCase
{
    public static void Main(String[] args)
    {
        String s = "Hello World";
        String new_s = "";

        for(int i = 0; i < s.Length; i++)
        {
            if (char.IsUpper(s[i]))
            {
                new_s += char.ToLower(s[i]);
            }
            else
            {
                new_s += char.ToUpper(s[i]);
            }
        }

        System.Console.WriteLine(new_s);
    }
}