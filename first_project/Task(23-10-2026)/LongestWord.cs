using System;

public class LongestWord
{
    public static void Main(String[] args)
    {
        
        String s = "Spongebob bestfriend is Patrick";

        String[] words = s.Split(' ');

        String longest = "";

        foreach(String word in words)
        {
            if(word.Length > longest.Length)
            {
                longest = word;
            }
        }

        System.Console.WriteLine($"The longest word is {longest}");

    }
}