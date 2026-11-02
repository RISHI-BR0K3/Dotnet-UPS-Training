using System;

namespace SealedMethod
{
    
    class a1
    {
        public virtual void Display()
        {
            Console.WriteLine("Hello");
        }
    }

    class a2 : a1
    {
        public sealed override void Display()
        {
            Console.WriteLine("World");
        }
    }

    class a3 : a2
    {
        public sealed override void Display()
        {
            Console.WriteLine("Error");
        }
    }

}