using System;

public class CountVowelsConsonants
{
    public static void Main(String[] args)
    {
        
        String s = "Education";
        s = s.ToLower();

        int vowels_count = 0;
        int consonants_count = 0;

        char[] vowels = {'a', 'e', 'i', 'o', 'u'};

        foreach(char ch in s)
        {
            if (vowels.Contains(ch))
            {
                vowels_count++;
            }
            else
            {
                consonants_count++;
            }
        }

        System.Console.WriteLine($"Vowels = {vowels_count}");
        System.Console.WriteLine($"Consonants = {consonants_count}");


    }
}