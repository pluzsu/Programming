using System;

public class Tippelos
{
    //static void Main(string[] args)
    public Tippelos()
    {
        Random rnd = new Random();
        int szam = rnd.Next(1, 1001);

        //Console.WriteLine("{0}", szam);

        int tippekSzama = 0;
        int tipp = 0;
        
        //TODO: algoritmus

        Console.WriteLine("Kitaláltad, {0} tippből", tippekSzama);

    }
}
