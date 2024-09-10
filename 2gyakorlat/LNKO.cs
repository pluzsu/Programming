using System;

public class LNKO
{
    //static void Main(string[] args)
    public LNKO()
	{
        int a, b;
        int lnko = 1;

        Console.Write("a: ");
        int.TryParse(Console.ReadLine(), out a);
        Console.Write("b: ");
        int.TryParse(Console.ReadLine(), out b);

        if (a < 1 || b < 1)
        {
            Console.WriteLine("a és b legyenek pozitív egész számok");
            return;
        }

        //TODO: algoritmus

        Console.WriteLine("{0} és {1} legnagyobb közös osztója {2}", a, b, lnko);

    }
}
