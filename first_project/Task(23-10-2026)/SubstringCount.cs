using System;

public class SubstringCount
{
    public static void Main(String[] args)
    {
        
        String s = "abcabcabc";
        String sub = "abc";

        int count = 0;

        for(int i = 0; i <= s.Length - sub.Length; i++)
        {
            if(s.Substring(i, sub.Length) == sub)
            {
                count++;
            }
        }

        System.Console.WriteLine($"The substring frequency = {count}");

    }
}