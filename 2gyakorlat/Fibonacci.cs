using System;

public class Fibonacci
{
    static void Main(string[] args)
    {
        int x;
        int f = 0;

        Console.Write("x: ");
        int.TryParse(Console.ReadLine(), out x);

        if (x < 1)
        {
            Console.WriteLine("x >= 1");
            return;
        }

        if (x == 1 || x == 2)
        {
            f = 1;
        }
        else
        {
            // Fibonacci számok: 1 1 2 3 5 8 13 21 ...
            // i == 2
            int fibIMinus2 = 0;
            int fibIMinus1 = 1;
            int fibI = 1;
            int i = 3;

            while (i <= x)
            {
                fibIMinus2 = fibIMinus1;
                fibIMinus1 = fibI;
                fibI = fibIMinus1 + fibIMinus2;
                i = i + 1;
            }

            f = fibI;
        }

        Console.WriteLine("Az {0}. Fibonacci szám: {1}", x, f);

    }
}
