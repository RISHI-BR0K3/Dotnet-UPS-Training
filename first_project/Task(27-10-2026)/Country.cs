using System;

class Country
{
    String name;
    String capital;
    String language;
    public Country(String name)
    {
        this.name = name;
    }
    public void Capital(String capital)
    {
        this.capital = capital;
        Console.WriteLine("Capital: " + capital);
    }
    public void Language(String language)
    {
        this.language = language;
        Console.WriteLine("Language: " + language);
    }

}

class India : Country
{
    public India(String name) : base(name)
    {
        Console.WriteLine("Country name: " + name);
    }
    void Capital(String capital)
    {
        base.Capital(capital);
    }
    void Language(String language)
    {
        base.Language(language);
    }
}

class USA : Country
{
    public USA(String name) : base(name)
    {
        Console.WriteLine("Country name: " + name);
    }
    void Capital(String capital)
    {
        base.Capital(capital);
    }
    void Language(String language)
    {
        base.Language(language);
    }
}

class UK : Country
{
    public UK(String name) : base(name)
    {
        Console.WriteLine("Country name: " + name);
    }
    void Capital(String capital)
    {
        base.Capital(capital);
    }
    void Language(String language)
    {
        base.Language(language);
    }
}

public class CountryProgram
{
    public static void Main(String[] args)
    {
        
        India IN = new India("India");
        IN.Capital("Delhi");
        IN.Language("Hindi");

        USA us = new USA("United States of America");
        us.Capital("New York");
        us.Language("English");

        UK uk = new UK("United Kingdom");
        uk.Capital("London");
        uk.Language("British English");

    }
}