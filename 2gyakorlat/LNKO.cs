using System;

public class LNKO {
    //static void Main(string[] args)
    public LNKO() {
        int a, b;
        int lnko = 1;

        Console.Write("a: ");
        int.TryParse(Console.ReadLine(), out a);
        Console.Write("b: ");
        int.TryParse(Console.ReadLine(), out b);

// TODO: ellenőrzés, hogy "a és b legyenek pozitív egész számok"

        
// TODO: algoritmus

        Console.WriteLine("{0} és {1} legnagyobb közös osztója {2}", a, b, lnko);

    }
}
