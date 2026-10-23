using System;

public class RemoveVowel
{
    public static void Main(String[] args)
    {
        
        String s = "Aeroplane";
        s = s.ToLower();

        String new_s = "";

        char[] vowels = {'a', 'e', 'i', 'o', 'u'};

        foreach(char ch in s)
        {
            if (vowels.Contains(ch))
            {
                continue;
            }
            else
            {
                new_s += ch;
            }
        }

        System.Console.WriteLine(new_s);

    }
}