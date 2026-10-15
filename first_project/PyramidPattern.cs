using System;

class PyramidPattern
{
    static void Main()
    {
        int n = 5;

        for (int i = 1; i <= n; i++)
        {
            for (int s = 1; s <= n - i; s++)
            {
                Console.Write("  ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write((char)('A' + j - 1) + " ");
            }

            for (int j = i - 1; j >= 1; j--)
            {
                Console.Write((char)('A' + j - 1) + " ");
            }

            Console.WriteLine();
        }
    }
}