using System;

public class Anagram
{
    public static void Main(String[] args)
    {
        String s1 = "listen";
        String s2 = "silent";

        char[] a1 = s1.ToCharArray();
        char[] a2 = s2.ToCharArray();

        Array.Sort(a1);
        Array.Sort(a2);

        String sorted1 = new String(a1);
        String sorted2 = new String(a2);

        if (sorted1 == sorted2)
        {
            Console.WriteLine("Anagram");
        }
        else
        {
            Console.WriteLine("Not Anagram");
        }
    }
}
