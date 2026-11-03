using System;

class DictionaryCollection
{
    
    public static void Main(string[] args)
    {
        
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict.Add(11 , 1);
        dict.Add(12 , 2);
        dict.Add(13 , 3);
        dict.Add(13 , 4);
        dict.Add(15 , 4);

        foreach(KeyValuePair<int, int> i in dict)
        {
            Console.WriteLine(i);
            Console.WriteLine(i.Key);
            Console.WriteLine(i.Value);
        }

    }

}