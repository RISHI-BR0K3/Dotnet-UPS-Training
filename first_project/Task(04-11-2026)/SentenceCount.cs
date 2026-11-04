using System;

static class StringExtensions
{
    public static int CountSentences(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }

        string[] sentences = text.Split(
            new char[] { '.' },
            StringSplitOptions.RemoveEmptyEntries
        );

        return sentences.Length;
    }

    public static int CountVowels(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }

        int count = 0;

        foreach (char ch in text)
        {
            if ("aeiouAEIOU".Contains(ch))
            {
                count++;
            }
        }

        return count;
    }
}

class SentenceCount
{
    static void Main()
    {
        string sentence = @"The toaster hummed a quiet tune right before it launched a single piece of toast across the kitchen.
                            An old map of the city appeared inside the library book on Tuesday morning.
                            She painted the front door bright yellow to trick the neighbors into thinking summer had arrived early.
                            A lone umbrella sat forgotten on the wooden bench as the fog rolled in from the harbor.
                            He tried to teach his cat how to play chess, but the cat preferred knocking over the knight.";

        int sentenceCount = sentence.CountSentences();
        int vowelCount = sentence.CountVowels();

        Console.WriteLine("Sentence Count: " + sentenceCount);
        Console.WriteLine("Vowel Count: " + vowelCount);
    }
}