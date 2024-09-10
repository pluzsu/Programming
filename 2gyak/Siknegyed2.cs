using System;

public class SiknegyedRekord
{
struct Pont
    {
        public double x;
        public double y;
    };
    //static void Main(string[] args)
    public SiknegyedRekord()
    {
        Pont p;
        int q = 0;

        Console.Write("x: ");
        double.TryParse(Console.ReadLine(), out p.x);
        Console.Write("y: ");
        double.TryParse(Console.ReadLine(), out p.y); 
        
        if (p.x >= 0 && p.y >= 0)
        {
            q = 1;
        }
        else if (p.x < 0 && p.y >= 0)
        {
            q = 2;
        }
        else if (p.x < 0 && p.y < 0)
        {
            q = 3;
        }
        else if (p.x >= 0 && p.y < 0)
        {
            q = 4;
        }

        Console.WriteLine("Síknegyed: {0}", q);
    }
}