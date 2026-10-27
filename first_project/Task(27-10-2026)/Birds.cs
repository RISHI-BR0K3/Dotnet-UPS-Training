using System;

class Birds
{
    string name;
    String sound;

    public Birds(string name)
    {
        this.name = name;
    }

    public void Display()
    {
        Console.WriteLine("Bird Name: " + name);
    }
    public void MakeSound(String sound)
    {
        this.sound = sound;
        Console.WriteLine("Sound: " + sound);
    }

}

class Parrot : Birds
{
    public Parrot(string name) : base(name)
    {
        Console.WriteLine("Parrot: ");
    }

    public void Display()
    {
        base.Display();
    }
    public void MakeSound()
    {
        base.MakeSound("kikikiki");
    }
}

class Sparrow : Birds
{
    public Sparrow(string name) : base(name)
    {
        Console.WriteLine("Sparrow: ");
    }

    public void Display()
    {
        base.Display();
    }
    public void MakeSound()
    {
        base.MakeSound("kukkukkukku");
    }
}

public class BirdProgram
{
    public static void Main(string[] args)
    {
        Parrot p = new Parrot("Patrick");
        p.Display();
        p.MakeSound();

        Sparrow s = new Sparrow("Tim");
        s.Display();
        s.MakeSound();
    }
}
