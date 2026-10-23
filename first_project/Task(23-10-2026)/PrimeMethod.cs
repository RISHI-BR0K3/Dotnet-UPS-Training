using System;

public class PrimeMethod
{
    class A1
    {
        public void prime(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("Neither prime nor composite");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Composite");
            }
        }
    }

    class A2
    {
        public static void Main(string[] args)
        {
            A1 obj = new A1();
            obj.prime(6);
        }
    }
}